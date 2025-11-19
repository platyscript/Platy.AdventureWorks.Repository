using System.Text.RegularExpressions;

public string WriteCode()
{
    CodeBuilder.Clear();

    if (GeneratorOptions.Data.Entity.Header.HasValue())
        CodeBuilder.AppendLine(GeneratorOptions.Data.Entity.Header).AppendLine();

    CodeBuilder.AppendLine("using System;");
    CodeBuilder.AppendLine("using System.Collections.Generic;");
    CodeBuilder.AppendLine();

    CodeBuilder.Append($"namespace {TemplateOptions.Namespace}");

    if (GeneratorOptions.Project.FileScopedNamespace)
    {
        CodeBuilder.AppendLine(";");
        CodeBuilder.AppendLine();
        GenerateClass();
    }
    else
    {
        CodeBuilder.AppendLine();
        CodeBuilder.AppendLine("{");

        using (CodeBuilder.Indent())
        {
            GenerateClass();
        }

        CodeBuilder.AppendLine("}");
    }

    return CodeBuilder.ToString();
}

private void GenerateClass()
{
    var entityClass = Entity.EntityClass.ToSafeName();

    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Entity class representing data for table '{Entity.TableName}'.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    if (GeneratorOptions.Data.Entity.MappingAttributes)
    {
        CodeBuilder.AppendLine($"[System.ComponentModel.DataAnnotations.Schema.Table(\"{Entity.TableName}\", Schema = \"{Entity.TableSchema}\")]");
    }
    CodeBuilder.AppendLine($"public partial class {entityClass}");

    if (TemplateOptions.BaseClass.HasValue())
    {
      foreach (var property in Entity.Properties)
      {
        if (property.ValueGenerated?.ToString() == "OnAdd") {
          var entityBaseClass = TemplateOptions.BaseClass.ToSafeName();
          using (CodeBuilder.Indent())
              CodeBuilder.AppendLine($": HasDomainEventsBase, {entityBaseClass}<{property.SystemType.ToType()}>");
          break;
        }
      }
    }

    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateConstructor();

        GenerateProperties();
        GenerateRelationshipProperties();
    }

    CodeBuilder.AppendLine("}");

}

private void GenerateConstructor()
{
    var relationships = Entity.Relationships
        .Where(r => r.Cardinality == Cardinality.Many)
        .OrderBy(r => r.PropertyName)
        .ToList();

    var entityClass = Entity.EntityClass.ToSafeName();

    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Initializes a new instance of the <see cref=\"{entityClass}\"/> class.");
        CodeBuilder.AppendLine("/// </summary>");
    }

    CodeBuilder.AppendLine($"public {entityClass}()");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        CodeBuilder.AppendLine("#region Generated Constructor");
        foreach (var relationship in relationships)
        {
            var propertyName = relationship.PropertyName.ToSafeName();

            var primaryNamespace = relationship.PrimaryEntity.EntityNamespace;
            var primaryName = relationship.PrimaryEntity.EntityClass.ToSafeName();
            var primaryFullName = Entity.EntityNamespace != primaryNamespace
                ? $"{primaryNamespace}.{primaryName}"
                : primaryName;

            CodeBuilder.AppendLine($"{propertyName} = new HashSet<{primaryFullName}>();");
        }
        CodeBuilder.AppendLine("#endregion");
    }

    CodeBuilder.AppendLine("}");
    CodeBuilder.AppendLine();
}

private string ReplaceHardcodedPropertyNames(string propertyName)
{
  string[] properties = ["PurchaseOrderId", "TerritoryId", 
          "SalesOrderId", "TransactionId", "JobCandidateId", "ProductModelId"];
  if(properties.Contains(propertyName))
  {
    return "Id";
  }
  return propertyName;
}

private void GenerateProperties()
{
    CodeBuilder.AppendLine("#region Generated Properties");
    foreach (var property in Entity.Properties)
    {
        var propertyType = property.SystemType.ToType();
        var propertyName = property.PropertyName.ToSafeName();
        if(property.ValueGenerated?.ToString() == "OnAdd")
        {
          var regex = String.Format($"^{Entity.TableName}(?=ID|Name)");
          propertyName = Regex.Replace(propertyName, regex, string.Empty).Replace("ID","Id");
          propertyName = ReplaceHardcodedPropertyNames(propertyName);
        }
        
        if (GeneratorOptions.Data.Entity.Document)
        {
            CodeBuilder.AppendLine("/// <summary>");
            CodeBuilder.AppendLine($"/// Gets or sets the property value representing column '{property.ColumnName}'.");
            CodeBuilder.AppendLine("/// </summary>");
            CodeBuilder.AppendLine("/// <value>");
            CodeBuilder.AppendLine($"/// The property value representing column '{property.ColumnName}'.");
            CodeBuilder.AppendLine("/// </value>");
        }

        if (GeneratorOptions.Data.Entity.MappingAttributes)
        {
            if (property.IsPrimaryKey == true)
            {
                CodeBuilder.AppendLine("[System.ComponentModel.DataAnnotations.Key()]");
            }

            if (property.IsConcurrencyToken == true)
            {
                CodeBuilder.AppendLine("[System.ComponentModel.DataAnnotations.ConcurrencyCheck()]");
            }

            CodeBuilder.AppendLine($"[System.ComponentModel.DataAnnotations.Schema.Column(\"{property.ColumnName}\", TypeName = \"{property.StoreType}\")]");

            if (property.IsRowVersion == true || property.ValueGenerated?.ToString() == "OnAddOrUpdate")
            {
                CodeBuilder.AppendLine("[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]");
            }
            else if (property.ValueGenerated?.ToString() == "OnAdd")
            {
                CodeBuilder.AppendLine("[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]");
            }
        }

//          if(property.ValueGenerated?.ToString() == "OnAdd")
//          {
//              CodeBuilder.AppendLine($"public new {propertyType} {propertyName} {{ get; set; }}");
//         } else 
        if (property.IsNullable == true && (property.SystemType.IsValueType || GeneratorOptions.Project.Nullable))
            CodeBuilder.AppendLine($"public {propertyType}? {propertyName} {{ get; set; }}");
        else if (GeneratorOptions.Project.Nullable && !property.SystemType.IsValueType)
            CodeBuilder.AppendLine($"public {propertyType} {propertyName} {{ get; set; }} = null!;");
        else
            CodeBuilder.AppendLine($"public {propertyType} {propertyName} {{ get; set; }}");

        CodeBuilder.AppendLine();
    }
    CodeBuilder.AppendLine("#endregion");
    CodeBuilder.AppendLine();
}

private void GenerateRelationshipProperties()
{
    CodeBuilder.AppendLine("#region Generated Relationships");
    foreach (var relationship in Entity.Relationships.OrderBy(r => r.PropertyName))
    {
        var propertyName = relationship.PropertyName.ToSafeName();
        var primaryNamespace = relationship.PrimaryEntity.EntityNamespace;
        var primaryName = relationship.PrimaryEntity.EntityClass.ToSafeName();
        var primaryFullName = Entity.EntityNamespace != primaryNamespace
            ? $"{primaryNamespace}.{primaryName}"
            : primaryName;

        if (relationship.Cardinality == Cardinality.Many)
        {
            if (GeneratorOptions.Data.Entity.Document)
            {
                CodeBuilder.AppendLine("/// <summary>");
                CodeBuilder.AppendLine($"/// Gets or sets the navigation collection for entity <see cref=\"{primaryFullName}\" />.");
                CodeBuilder.AppendLine("/// </summary>");
                CodeBuilder.AppendLine("/// <value>");
                CodeBuilder.AppendLine($"/// The navigation collection for entity <see cref=\"{primaryFullName}\" />.");
                CodeBuilder.AppendLine("/// </value>");
            }


            CodeBuilder.AppendLine($"public virtual ICollection<{primaryFullName}> {propertyName} {{ get; set; }}");
            CodeBuilder.AppendLine();
        }
        else
        {
            if (GeneratorOptions.Data.Entity.Document)
            {
                CodeBuilder.AppendLine("/// <summary>");
                CodeBuilder.AppendLine($"/// Gets or sets the navigation property for entity <see cref=\"{primaryFullName}\" />.");
                CodeBuilder.AppendLine("/// </summary>");
                CodeBuilder.AppendLine("/// <value>");
                CodeBuilder.AppendLine($"/// The navigation property for entity <see cref=\"{primaryFullName}\" />.");
                CodeBuilder.AppendLine("/// </value>");

                foreach (var property in relationship.Properties)
                    CodeBuilder.AppendLine($"/// <seealso cref=\"{property.PropertyName}\" />");
            }

            if (!GeneratorOptions.Project.Nullable)
                CodeBuilder.AppendLine($"public virtual {primaryFullName} {propertyName} {{ get; set; }}");
            else if (relationship.Cardinality == Cardinality.One)
                CodeBuilder.AppendLine($"public virtual {primaryFullName} {propertyName} {{ get; set; }} = null!;");
            else
                CodeBuilder.AppendLine($"public virtual {primaryFullName}? {propertyName} {{ get; set; }}");

            CodeBuilder.AppendLine();
        }
    }
    CodeBuilder.AppendLine("#endregion");
    CodeBuilder.AppendLine();
}

// run script
WriteCode()
