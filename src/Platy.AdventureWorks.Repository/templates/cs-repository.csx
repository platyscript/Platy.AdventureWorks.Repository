using System.Text.RegularExpressions;

public string WriteCode()
{
    CodeBuilder.Clear();
    var hasIdentity = false;
    foreach (var property in Entity.Properties)
    {
      if (property.ValueGenerated?.ToString() == "OnAdd") {
         hasIdentity = true;
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
    CodeBuilder.AppendLine("using System.Linq.Expressions;");
    CodeBuilder.AppendLine("using Platy.AdventureWorks.Repository.BaseRepository;");
    CodeBuilder.AppendLine("using Platy.AdventureWorks.Repository.Data.Entities;");
    CodeBuilder.AppendLine("using Platy.AdventureWorks.Repository.Domain.Models;");
    CodeBuilder.AppendLine("using Platy.AdventureWorks.Repository.Events;");
    CodeBuilder.AppendLine("using Platy.Shared;");
    CodeBuilder.AppendLine("using FluentValidation;");
    CodeBuilder.AppendLine("using Ardalis.Result;");
    CodeBuilder.AppendLine("using Ardalis.Result.FluentValidation;");
    CodeBuilder.AppendLine("using MediatR;");

    CodeBuilder.AppendLine();
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

    var identityPropertyType = "int";
    foreach (var property in Entity.Properties)
    {
      if (property.ValueGenerated?.ToString() == "OnAdd") {
         identityPropertyType = property.SystemType.ToType();
      }
    }
    
    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Repository class representing data for table '{Entity.TableName}'.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($"[RegisterScoped]");
    CodeBuilder.AppendLine($"public class {entityClass}Repository");

    using (CodeBuilder.Indent())
    {
      CodeBuilder.AppendLine($": EntityRepository<{entityClass},{identityPropertyType}, {entityClass}ReadModel, {entityClass}CreateModel, {entityClass}UpdateModel>, I{entityClass}Repository");
    }

    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateConstructor();
        GenerateAsyncMethods();
    }

    CodeBuilder.AppendLine("}");
    
    CodeBuilder.AppendLine();
    CodeBuilder.AppendLine($"public interface I{entityClass}Repository");
    using (CodeBuilder.Indent())
    {
      CodeBuilder.AppendLine($": IRepository<{entityClass},{identityPropertyType}, {entityClass}ReadModel, {entityClass}CreateModel, {entityClass}UpdateModel>");
    }
    CodeBuilder.AppendLine("{");
    CodeBuilder.AppendLine("}");
    CodeBuilder.AppendLine();
}

private void GenerateConstructor()
{
    var entityClass = Entity.EntityClass.ToSafeName();

    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Initializes a new instance of the <see cref=\"{entityClass}Repository\"/> class.");
        CodeBuilder.AppendLine("/// </summary>");
    }

    CodeBuilder.AppendLine($"public {entityClass}Repository(IServiceProvider serviceProvider,");
    using (CodeBuilder.Indent())
    {
     CodeBuilder.AppendLine($"IMapper mapper,");
     CodeBuilder.AppendLine($"IMediator mediator,");
     CodeBuilder.AppendLine($"ILogger<{entityClass}Repository> logger,");
     CodeBuilder.AppendLine($"IValidator<{entityClass}CreateModel> createValidator,");
     CodeBuilder.AppendLine($"IValidator<{entityClass}UpdateModel> updateValidator)");
     CodeBuilder.AppendLine($": base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)");
    }
    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        CodeBuilder.AppendLine("#region Generated Constructor");
        CodeBuilder.AppendLine("#endregion");
    }

    CodeBuilder.AppendLine("}");
    CodeBuilder.AppendLine();
}

private void GenerateAsyncMethods()
{
    var entityClass = Entity.EntityClass.ToSafeName();
    var  identityPropertyType = "int";
    foreach (var property in Entity.Properties)
    {
      if (property.ValueGenerated?.ToString() == "OnAdd") {
         identityPropertyType = property.SystemType.ToType();
         break;
      }
    }
    CodeBuilder.AppendLine("#region Generated methods");
    CodeBuilder.AppendLine("");
    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Gets an <see cref=\"{entityClass}ReadModel\" />.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($"public async Task<Result<{entityClass}ReadModel>> GetAsync({identityPropertyType} id,");
    CodeBuilder.AppendLine("  CancellationToken cancellationToken) =>");
    CodeBuilder.AppendLine($"  await ReadModel<{entityClass}, {identityPropertyType}>(id,");
    CodeBuilder.AppendLine("    cancellationToken);");
  
    CodeBuilder.AppendLine("");
    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Returns a list of <see cref=\"{entityClass}ReadModel\" />.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($"public async Task<Result<IReadOnlyList<{entityClass}ReadModel>>> ListAsync(");
    CodeBuilder.AppendLine($"   Expression<Func<{entityClass}, bool>>? predicate,");
    CodeBuilder.AppendLine($"   CancellationToken cancellationToken) =>");
    CodeBuilder.AppendLine($"   await QueryModel<{entityClass},{identityPropertyType}>(predicate, cancellationToken);");
    
    CodeBuilder.AppendLine("");
    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Creates an <see cref=\"{entityClass}\" />.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($" public async Task<Result<{entityClass}ReadModel>> CreateAsync(");
    CodeBuilder.AppendLine($"   {entityClass}CreateModel createModel,");
    CodeBuilder.AppendLine($"   CancellationToken cancellationToken) =>");
    CodeBuilder.AppendLine($"   await CreateModel(createModel,");
    CodeBuilder.AppendLine($"     new {entityClass}CreatedEvent(),");
    CodeBuilder.AppendLine($"     cancellationToken);");

    CodeBuilder.AppendLine("");
    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Updates a <see cref=\"{entityClass}\" />.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($" public async Task<Result<{entityClass}ReadModel>> UpdateAsync(");
    CodeBuilder.AppendLine($"   {identityPropertyType} id,");
    CodeBuilder.AppendLine($"   {entityClass}UpdateModel updateModel,");
    CodeBuilder.AppendLine($"   CancellationToken cancellationToken) =>");
    CodeBuilder.AppendLine($"   await UpdateModel(id,");
    CodeBuilder.AppendLine($"     updateModel,");
    CodeBuilder.AppendLine($"     new {entityClass}UpdatedEvent(),");
    CodeBuilder.AppendLine($"     cancellationToken);");

    CodeBuilder.AppendLine("");
    if (GeneratorOptions.Data.Entity.Document)
    {
        CodeBuilder.AppendLine("/// <summary>");
        CodeBuilder.AppendLine($"/// Deletes a <see cref=\"{entityClass}\" />.");
        CodeBuilder.AppendLine("/// </summary>");
    }
    CodeBuilder.AppendLine($"  public virtual async Task<Result<{entityClass}ReadModel>> DeleteAsync(");
    CodeBuilder.AppendLine($"   {identityPropertyType} id,");
    CodeBuilder.AppendLine($"   CancellationToken cancellationToken) =>");
    CodeBuilder.AppendLine($"   await DeleteModel(id,");
    CodeBuilder.AppendLine($"     new {entityClass}DeletedEvent(),");
    CodeBuilder.AppendLine($"     cancellationToken);");
    
    CodeBuilder.AppendLine("");
    
    CodeBuilder.AppendLine("#endregion");
}

WriteCode()
