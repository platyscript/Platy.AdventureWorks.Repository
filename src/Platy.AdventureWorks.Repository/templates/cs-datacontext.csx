using System;
using System.Globalization;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

public string WriteCode()
{
    CodeBuilder.Clear();

    if (GeneratorOptions.Data.Context.Header.HasValue())
        CodeBuilder.AppendLine(GeneratorOptions.Data.Context.Header).AppendLine();

    CodeBuilder.AppendLine("using System;");
    CodeBuilder.AppendLine();
    CodeBuilder.AppendLine("using Microsoft.EntityFrameworkCore;");
    CodeBuilder.AppendLine("using Microsoft.EntityFrameworkCore.Metadata;");
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
    var contextClass = EntityContext.ContextClass.ToSafeName();
    var baseClass = EntityContext.ContextBaseClass.ToSafeName();

    if (GeneratorOptions.Data.Context.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine("/// A <see cref=\"DbContext\" /> instance represents a session with the database and can be used to query and save instances of entities. ");
        CodeBuilder.AppendLine("/// </summary>");
    }

    CodeBuilder.AppendLine($"internal partial class {contextClass} : {baseClass}");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateConstructors();
        GenerateDbSets();
        GenerateOnConfiguring();
    }

    CodeBuilder.AppendLine("}");
}

private void GenerateConstructors()
{
    var contextName = EntityContext.ContextClass.ToSafeName();

    if (GeneratorOptions.Data.Context.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Initializes a new instance of the <see cref=\"{contextName}\"/> class.");
        CodeBuilder.AppendLine("/// </summary>");
        CodeBuilder.AppendLine("/// <param name=\"GeneratorOptions\">The GeneratorOptions to be used by this <see cref=\"DbContext\" />.</param>");
    }

    CodeBuilder.AppendLine($"public {contextName}(DbContextOptions<{contextName}> options)")
        .IncrementIndent()
        .AppendLine(": base(options)")
        .DecrementIndent()
        .AppendLine("{")
        .AppendLine("}")
        .AppendLine();
}

private void GenerateDbSets()
{
    CodeBuilder.AppendLine("#region Generated Properties");
    foreach (var entityType in EntityContext.Entities.OrderBy(e => e.ContextProperty))
    {
        var entityClass = entityType.EntityClass.ToSafeName();
        var propertyName = entityType.ContextProperty.ToSafeName();
        var fullName = $"{entityType.EntityNamespace}.{entityClass}";

        if (GeneratorOptions.Data.Context.Document)
        {
            CodeBuilder.AppendLine("/// <summary>");
            CodeBuilder.AppendLine($"/// Gets or sets the <see cref=\"T:Microsoft.EntityFrameworkCore.DbSet`1\" /> that can be used to query and save instances of <see cref=\"{fullName}\"/>.");
            CodeBuilder.AppendLine("/// </summary>");
            CodeBuilder.AppendLine("/// <value>");
            CodeBuilder.AppendLine($"/// The <see cref=\"T:Microsoft.EntityFrameworkCore.DbSet`1\" /> that can be used to query and save instances of <see cref=\"{fullName}\"/>.");
            CodeBuilder.AppendLine("/// </value>");
        }

        CodeBuilder.Append($"public virtual DbSet<{fullName}> {propertyName} {{ get; set; }}");
        if (GeneratorOptions.Project.Nullable)
            CodeBuilder.Append(" = null!;");

        CodeBuilder.AppendLine();
        CodeBuilder.AppendLine();
    }

    CodeBuilder.AppendLine("#endregion");

    if (EntityContext.Entities.Any())
        CodeBuilder.AppendLine();
}

private void GenerateOnConfiguring()
{
    if (GeneratorOptions.Data.Context.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine("/// Configure the model that was discovered from the entity types exposed in <see cref=\"T:Microsoft.EntityFrameworkCore.DbSet`1\" /> properties on this context.");
        CodeBuilder.AppendLine("/// </summary>");
        CodeBuilder.AppendLine("/// <param name=\"modelBuilder\">The builder being used to construct the model for this context.</param>");
    }

    CodeBuilder.AppendLine("protected override void OnModelCreating(ModelBuilder modelBuilder)");
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        CodeBuilder.AppendLine("#region Generated Configuration");
        foreach (var entityType in EntityContext.Entities.OrderBy(e => e.MappingClass))
        {
            var mappingClass = entityType.MappingClass.ToSafeName();
            mappingClass = mappingClass.Replace("Map","Configuration");
            var mappingNamespace = entityType.MappingNamespace.Replace("Mapping","EntityConfiguration");
            CodeBuilder.AppendLine($"modelBuilder.ApplyConfiguration(new {mappingNamespace}.{mappingClass}());");
        }

        CodeBuilder.AppendLine("#endregion");
    }

    CodeBuilder.AppendLine("}");
}

// run script
WriteCode()
