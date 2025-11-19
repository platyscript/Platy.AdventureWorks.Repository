using System.Text.RegularExpressions;

public string WriteCode()
{
    CodeBuilder.Clear();
    var hasIdentity = false;
    var identityPropertyType = "int";
    var identityPropertyName = "test";
    foreach (var property in Entity.Properties)
    {
      if (property.ValueGenerated?.ToString() == "OnAdd") {
         hasIdentity = true;
         identityPropertyType = property.SystemType.ToType();
         identityPropertyName = property.PropertyName;
         break;
      }
    }
 
    if(hasIdentity == false)
    {
        return CodeBuilder.ToString();
    }

    if (GeneratorOptions.Data.Entity.Header.HasValue())
        CodeBuilder.AppendLine(GeneratorOptions.Data.Entity.Header).AppendLine();

    CodeBuilder.AppendLine("using System;");
    CodeBuilder.AppendLine("using System.Collections.Generic;");
    CodeBuilder.AppendLine("using Platy.AdventureWorks.Repository.BaseEvent;");
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
        CodeBuilder.AppendLine($"/// Event class representing the data when changes are made to the table '{Entity.TableName}'.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($"public class {TemplateOptions.FileName.Replace(".cs","")}");
    using (CodeBuilder.Indent())
    {
      CodeBuilder.AppendLine($": EntityEventBase");
    }

    CodeBuilder.AppendLine("{");
    CodeBuilder.AppendLine("}");
}

WriteCode()
