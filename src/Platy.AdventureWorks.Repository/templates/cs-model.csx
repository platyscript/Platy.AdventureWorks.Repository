public  string WriteCode()
{
    CodeBuilder.Clear();

    if (Model.ModelHeader.HasValue())
        CodeBuilder.AppendLine(Model.ModelHeader).AppendLine();

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
    var modelClass = Model.ModelClass.ToSafeName();


    if (ShouldDocument())
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine("/// View Model class");
        CodeBuilder.AppendLine("/// </summary>");
    }
    if (Model.ModelAttributes.HasValue())
    {
        CodeBuilder.AppendLine(Model.ModelAttributes);
    }
    CodeBuilder.AppendLine($"public partial class {modelClass}");

    if (Model.ModelBaseClass.HasValue())
    {
        var modelBase = Model.ModelBaseClass.ToSafeName();
        using (CodeBuilder.Indent())
            CodeBuilder.AppendLine($": {modelBase}");
    }

    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateProperties();
    }

    CodeBuilder.AppendLine("}");

}


private void GenerateProperties()
{
    CodeBuilder.AppendLine("#region Generated Properties");
    foreach (var property in Model.Properties)
    {
        var propertyType = property.SystemType.ToType();
        var propertyName = property.PropertyName.ToSafeName();
        
        if (ShouldDocument())
        {
            CodeBuilder.AppendLine("/// <summary>");
            CodeBuilder.AppendLine($"/// Gets or sets the property value for '{property.PropertyName}'.");
            CodeBuilder.AppendLine("/// </summary>");
            CodeBuilder.AppendLine("/// <value>");
            CodeBuilder.AppendLine($"/// The property value for '{property.PropertyName}'.");
            CodeBuilder.AppendLine("/// </value>");
        }

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


private bool ShouldDocument()
{
    if (Model.ModelType == ModelType.Create)
        return GeneratorOptions.Model.Create.Document;

    if (Model.ModelType == ModelType.Update)
        return GeneratorOptions.Model.Update.Document;

    return GeneratorOptions.Model.Read.Document;
}

// run script
WriteCode()
