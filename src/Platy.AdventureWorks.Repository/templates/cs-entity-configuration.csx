using System.Globalization;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

public string WriteCode()
{
    CodeBuilder.Clear();

    if (GeneratorOptions.Data.Mapping.Header.HasValue())
        CodeBuilder.AppendLine(GeneratorOptions.Data.Mapping.Header).AppendLine();

    CodeBuilder.AppendLine("using System;");
    CodeBuilder.AppendLine("using System.Collections.Generic;");
    CodeBuilder.AppendLine();
    CodeBuilder.AppendLine("using Microsoft.EntityFrameworkCore;");
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
    var mappingClass = Entity.MappingClass.ToSafeName();
    mappingClass = mappingClass.Replace("Map", "Configuration");
    var entityClass = Entity.EntityClass.ToSafeName();
    var safeName = $"{Entity.EntityNamespace}.{entityClass}";

    if (GeneratorOptions.Data.Mapping.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Allows configuration for an entity type <see cref=\"{safeName}\" />");
        CodeBuilder.AppendLine("/// </summary>");
    }

    CodeBuilder.AppendLine($"internal partial class {mappingClass}");

    using (CodeBuilder.Indent())
        CodeBuilder.AppendLine($": IEntityTypeConfiguration<{safeName}>");

    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateConfigure();
        GenerateConstants();
    }

    CodeBuilder.AppendLine("}");

}

private void GenerateConstants()
{
    var entityClass = Entity.EntityClass.ToSafeName();
    var safeName = $"{Entity.EntityNamespace}.{entityClass}";

    CodeBuilder.AppendLine("#region Generated Constants");

    CodeBuilder.AppendLine("internal readonly struct Table");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {

        if (GeneratorOptions.Data.Mapping.Document)
            CodeBuilder.AppendLine($"/// <summary>Table Schema name constant for entity <see cref=\"{safeName}\" /></summary>");

        CodeBuilder.AppendLine($"public const string Schema = \"{Entity.TableSchema}\";");

        if (GeneratorOptions.Data.Mapping.Document)
            CodeBuilder.AppendLine($"/// <summary>Table Name constant for entity <see cref=\"{safeName}\" /></summary>");

        CodeBuilder.AppendLine($"public const string Name = \"{Entity.TableName}\";");
    }

    CodeBuilder.AppendLine("}");

    CodeBuilder.AppendLine();
    CodeBuilder.AppendLine("internal readonly struct Columns");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        foreach (var property in Entity.Properties)
        {
            if (GeneratorOptions.Data.Mapping.Document)
                CodeBuilder.AppendLine($"/// <summary>Column Name constant for property <see cref=\"{safeName}.{property.PropertyName}\" /></summary>");

            CodeBuilder.AppendLine($"public const string {property.PropertyName.ToSafeName()} = {property.ColumnName.ToLiteral()};");
        }
    }

    CodeBuilder.AppendLine("}");
    CodeBuilder.AppendLine("#endregion");
}

private void GenerateConfigure()
{
    var entityClass = Entity.EntityClass.ToSafeName();
    var entityFullName = $"{Entity.EntityNamespace}.{entityClass}";

    if (GeneratorOptions.Data.Mapping.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Configures the entity of type <see cref=\"{entityFullName}\" />");
        CodeBuilder.AppendLine("/// </summary>");
        CodeBuilder.AppendLine("/// <param name=\"builder\">The builder to be used to configure the entity type.</param>");
    }

    CodeBuilder.AppendLine($"public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<{entityFullName}> builder)");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        CodeBuilder.AppendLine("#region Generated Configure");

        GenerateTableMapping();
        GenerateKeyMapping();
        GeneratePropertyMapping();
        GenerateRelationshipMapping();

        CodeBuilder.AppendLine("#endregion");
    }

    CodeBuilder.AppendLine("}");
    CodeBuilder.AppendLine();
}


private void GenerateRelationshipMapping()
{
    CodeBuilder.AppendLine("// relationships");
    foreach (var relationship in Entity.Relationships.Where(e => e.IsMapped))
    {
        GenerateRelationshipMapping(relationship);
        CodeBuilder.AppendLine();
    }

}

private string ReplacePropertyNameWithId(string propertyName, bool isOnAdd)
{
   if (propertyName.Contains($"{Entity.TableName}") && propertyName.Contains("ID") && isOnAdd)
   {
      return "Id";
   }
   return propertyName;
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

private void GenerateRelationshipMapping(Relationship relationship)
{
   var regex = String.Format($"^{Entity.TableName}(?=ID|Name)");
//    if (relationship.PropertyName.Contains($"{Entity.TableName}") && relationship.PropertyName.Contains("ID"))
//    {
//       relationship.PropertyName = "Id";
//    }
//    if (relationship.PrimaryPropertyName.Contains($"{Entity.TableName}") && relationship.PrimaryPropertyName.Contains("ID"))
//    {
//       relationship.PrimaryPropertyName = "Id";
//    }
   relationship.PropertyName = Regex.Replace(relationship.PropertyName, regex, string.Empty).Replace("ID","Id");
   relationship.PrimaryPropertyName = Regex.Replace(relationship.PrimaryPropertyName, regex, string.Empty).Replace("ID","Id");

     relationship.PropertyName = ReplaceHardcodedPropertyNames(relationship.PropertyName);
     relationship.PrimaryPropertyName = ReplaceHardcodedPropertyNames(relationship.PrimaryPropertyName);

    CodeBuilder.Append("builder.HasOne(t => t.");
    CodeBuilder.Append(relationship.PropertyName);
    CodeBuilder.Append(")");
    CodeBuilder.AppendLine();

    CodeBuilder.IncrementIndent();

    CodeBuilder.Append(relationship.PrimaryCardinality == Cardinality.Many
        ? ".WithMany(t => t."
        : ".WithOne(t => t.");

    CodeBuilder.Append(relationship.PrimaryPropertyName);
    CodeBuilder.Append(")");

    CodeBuilder.AppendLine();
    CodeBuilder.Append(".HasForeignKey");
    if (relationship.IsOneToOne)
    {
        CodeBuilder.Append("<");
        CodeBuilder.Append(Entity.EntityNamespace);
        CodeBuilder.Append(".");
        CodeBuilder.Append(Entity.EntityClass.ToSafeName());
        CodeBuilder.Append(">");
    }
    CodeBuilder.Append("(d => ");

    var keys = relationship.Properties;
    bool wroteLine = false;

    if (keys.Count == 1)
    {
//         var propertyName = ReplacePropertyNameWithId(keys[0].PropertyName.ToSafeName()
//                                   ,keys[0].ValueGenerated?.ToString() == "OnAdd");
        var propertyName = keys[0].PropertyName.ToSafeName();
        propertyName = Regex.Replace(propertyName, regex, string.Empty).Replace("ID","Id");
        propertyName = keys[0].ValueGenerated?.ToString() == "OnAdd" 
                          ? ReplaceHardcodedPropertyNames(propertyName) : propertyName;
        CodeBuilder.Append($"d.{propertyName}");
    }
    else
    {
        CodeBuilder.Append("new { ");
        foreach (var p in keys)
        {
            if (wroteLine)
                CodeBuilder.Append(", ");

            CodeBuilder.Append($"d.{p.PropertyName}");
            wroteLine = true;
        }
        CodeBuilder.Append("}");
    }
    CodeBuilder.Append(")");

    var primaryKeys = relationship.PrimaryProperties;
    var nonPrimaryPrincipalKey = !primaryKeys
        .Select(pp => relationship.PrimaryEntity.Properties.ByProperty(pp.PropertyName))
        .All(p => p?.IsPrimaryKey ?? true);

    if (nonPrimaryPrincipalKey)
    {
        CodeBuilder.AppendLine();

        CodeBuilder.Append(".HasPrincipalKey(t => ");
        if (primaryKeys.Count > 1)
        {
            CodeBuilder.Append("new { ");
            CodeBuilder.Append(string.Join(", ", primaryKeys.Select(pp => $"t.{pp.PropertyName.ToSafeName()}")));
            CodeBuilder.Append(" }");
        }
        else
        {
            //var propertyName = ReplacePropertyNameWithId(primaryKeys.First().PropertyName.ToSafeName());
           var propertyName = primaryKeys.First().PropertyName.ToSafeName();
           propertyName = Regex.Replace(propertyName, regex, string.Empty).Replace("ID","Id");
           propertyName = primaryKeys.First().ValueGenerated?.ToString() == "OnAdd" 
                            ? ReplaceHardcodedPropertyNames(propertyName) : propertyName;
//         var propertyName = ReplacePropertyNameWithId(primaryKeys.First().PropertyName.ToSafeName()
//                                   ,primaryKeys.First().ValueGenerated?.ToString() == "OnAdd");
            CodeBuilder.Append($"t.{propertyName}");
        }
        CodeBuilder.Append(")");
    }

    if (!string.IsNullOrEmpty(relationship.RelationshipName))
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append(".HasConstraintName(\"");
        CodeBuilder.Append(relationship.RelationshipName);
        CodeBuilder.Append("\")");
    }

    CodeBuilder.DecrementIndent();

    CodeBuilder.AppendLine(";");
}


private void GeneratePropertyMapping()
{
    CodeBuilder.AppendLine("// properties");
    foreach (var property in Entity.Properties)
    {
        GeneratePropertyMapping(property);
        CodeBuilder.AppendLine();
    }
}

private void GeneratePropertyMapping(Property property)
{
    bool isString = property.SystemType == typeof(string);
    bool isByteArray = property.SystemType == typeof(byte[]);
    
    var regex = String.Format($"^{Entity.TableName}(?=ID|Name)");
    property.PropertyName = Regex.Replace(property.PropertyName, regex, string.Empty).Replace("ID","Id");
    property.PropertyName = property.ValueGenerated?.ToString() == "OnAdd" 
                            ? ReplaceHardcodedPropertyNames(property.PropertyName) : property.PropertyName;
    //property.PropertyName = ReplacePropertyNameWithId(property.propertyName);
//      property.PropertyName = ReplacePropertyNameWithId(property.PropertyName.ToSafeName()
//                                   ,property.ValueGenerated?.ToString() == "OnAdd");
    CodeBuilder.Append($"builder.Property(t => t.{property.PropertyName})");

    CodeBuilder.IncrementIndent();
    if (property.IsRequired)
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append(".IsRequired()");
    }

    if (property.IsRowVersion == true)
    {
        if (property.DataType.ToString() == "DbType.Binary" && property.SystemType != typeof(byte[]))
        {
            CodeBuilder.AppendLine();
            CodeBuilder.Append(".HasConversion<byte[]>()");
        }
        CodeBuilder.AppendLine();
        CodeBuilder.Append(".IsRowVersion()");
    }

    if (property.IsConcurrencyToken == true)
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append(".IsConcurrencyToken()");
    }

    CodeBuilder.AppendLine();
    CodeBuilder.Append($".HasColumnName({property.ColumnName.ToLiteral()})");

    if (!string.IsNullOrEmpty(property.StoreType))
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append($".HasColumnType({property.StoreType.ToLiteral()})");
    }

    if ((isString || isByteArray) && property.Size > 0)
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append($".HasMaxLength({property.Size.Value.ToString(CultureInfo.InvariantCulture)})");
    }

    // only use for simple types
    if (property.DefaultValue is bool or int or long or byte or double or float or short)
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append($".HasDefaultValue({property.DefaultValue?.ToString()?.ToLowerInvariant()})");
    }
    else if (!string.IsNullOrEmpty(property.Default))
    {
        CodeBuilder.AppendLine();
        CodeBuilder.Append($".HasDefaultValueSql({property.Default.ToLiteral()})");
    }

    switch (property.ValueGenerated)
    {
        case ValueGenerated.OnAdd:
            CodeBuilder.AppendLine();
            CodeBuilder.Append(".ValueGeneratedOnAdd()");
            break;
        case ValueGenerated.OnAddOrUpdate:
            CodeBuilder.AppendLine();
            CodeBuilder.Append(".ValueGeneratedOnAddOrUpdate()");
            break;
        case ValueGenerated.OnUpdate:
            CodeBuilder.AppendLine();
            CodeBuilder.Append(".ValueGeneratedOnUpdate()");
            break;
    }
    CodeBuilder.DecrementIndent();

    CodeBuilder.AppendLine(";");
}


private void GenerateKeyMapping()
{
    CodeBuilder.AppendLine("// key");

    var keys = Entity.Properties.Where(p => p.IsPrimaryKey == true).ToList();
    if (keys.Count == 0)
    {
        CodeBuilder.AppendLine("builder.HasNoKey();");
        CodeBuilder.AppendLine();

        return;
    }

    CodeBuilder.Append("builder.HasKey(t => ");

    if (keys.Count == 1)
    {
        var regex = String.Format($"^{Entity.TableName}(?=ID|Name)");
        var propertyName = keys[0].PropertyName.ToSafeName();
//         propertyName = ReplacePropertyNameWithId(
//                                   propertyName 
//                                   ,keys[0].ValueGenerated?.ToString() == "OnAdd");
        propertyName = Regex.Replace(propertyName, regex, string.Empty).Replace("ID","Id");
        propertyName = keys[0].ValueGenerated?.ToString() == "OnAdd" 
                            ? ReplaceHardcodedPropertyNames(propertyName) : propertyName;
        CodeBuilder.AppendLine($"t.{propertyName});");
        CodeBuilder.AppendLine();

        return;
    }

    bool wroteLine = false;

    CodeBuilder.Append("new { ");
    foreach (var p in keys)
    {
        if (wroteLine)
            CodeBuilder.Append(", ");

        CodeBuilder.Append("t.");
        var regex = String.Format($"^{Entity.TableName}(?=ID|Name)");
        //var propertyName = ReplacePropertyNameWithId(p.PropertyName.ToSafeName());
//            var propertyName = ReplacePropertyNameWithId(p.PropertyName.ToSafeName()
//            ,p.ValueGenerated?.ToString() == "OnAdd");
        var propertyName = p.PropertyName.ToSafeName();
        propertyName = Regex.Replace(propertyName, regex, string.Empty).Replace("ID","Id");
        propertyName = p.ValueGenerated?.ToString() == "OnAdd" 
                            ? ReplaceHardcodedPropertyNames(propertyName) : propertyName;
        CodeBuilder.Append(propertyName);
        wroteLine = true;
    }

    CodeBuilder.AppendLine(" });");
    CodeBuilder.AppendLine();
}

private void GenerateTableMapping()
{
    CodeBuilder.AppendLine("// table");

    var method = Entity.IsView
        ? nameof(RelationalEntityTypeBuilderExtensions.ToView)
        : nameof(RelationalEntityTypeBuilderExtensions.ToTable);

    CodeBuilder.AppendLine(Entity.TableSchema.HasValue()
        ? $"builder.{method}(\"{Entity.TableName}\", \"{Entity.TableSchema}\");"
        : $"builder.{method}(\"{Entity.TableName}\");");

    CodeBuilder.AppendLine();

    if (Entity.TemporalTableName.IsNullOrEmpty())
        return;

    CodeBuilder.AppendLine("builder");
    CodeBuilder.IncrementIndent();
    CodeBuilder.AppendLine(".ToTable(tableBuilder => tableBuilder");
    CodeBuilder.IncrementIndent();
    CodeBuilder.AppendLine(".IsTemporal(temporalBuilder =>");
    CodeBuilder.AppendLine("{");
    CodeBuilder.IncrementIndent();
    CodeBuilder.AppendLine("temporalBuilder");
    CodeBuilder.IncrementIndent();

    CodeBuilder.AppendLine(Entity.TemporalTableSchema.HasValue()
        ? $".UseHistoryTable(\"{Entity.TemporalTableName}\", \"{Entity.TemporalTableSchema}\");"
        : $".UseHistoryTable(\"{Entity.TemporalTableName}\");");

    CodeBuilder.DecrementIndent();
    CodeBuilder.AppendLine("temporalBuilder");
    CodeBuilder.IncrementIndent();
    CodeBuilder.AppendLine($".HasPeriodStart(\"{Entity.TemporalStartProperty}\")");
    CodeBuilder.AppendLine($".HasColumnName(\"{Entity.TemporalStartColumn}\");");

    CodeBuilder.DecrementIndent();
    CodeBuilder.AppendLine("temporalBuilder");
    CodeBuilder.IncrementIndent();
    CodeBuilder.AppendLine($".HasPeriodEnd(\"{Entity.TemporalEndProperty}\")");
    CodeBuilder.AppendLine($".HasColumnName(\"{Entity.TemporalEndColumn}\");");

    CodeBuilder.DecrementIndent();
    CodeBuilder.DecrementIndent();
    CodeBuilder.AppendLine("})");

    CodeBuilder.DecrementIndent();
    CodeBuilder.AppendLine(");");

    CodeBuilder.DecrementIndent();

    CodeBuilder.AppendLine();
}
    
// run script
WriteCode()
