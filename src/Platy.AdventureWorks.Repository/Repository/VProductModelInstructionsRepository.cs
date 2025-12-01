using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;
using Platy.Shared;
using FluentValidation;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using MediatR;


namespace Platy.AdventureWorks.Repository;

/// <summary>
/// Repository class representing data for table 'vProductModelInstructions'.
/// </summary>
[RegisterScoped]
public class VProductModelInstructionsRepository
    : EntityRepository<VProductModelInstructions,int, VProductModelInstructionsReadModel, VProductModelInstructionsCreateModel, VProductModelInstructionsUpdateModel>, IVProductModelInstructionsRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelInstructionsRepository"/> class.
    /// </summary>
    public VProductModelInstructionsRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VProductModelInstructionsRepository> logger,
        IValidator<VProductModelInstructionsCreateModel> createValidator,
        IValidator<VProductModelInstructionsUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VProductModelInstructionsReadModel" />.
    /// </summary>
    public async Task<Result<VProductModelInstructionsReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VProductModelInstructions, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VProductModelInstructionsReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VProductModelInstructionsReadModel>>> ListAsync(
       Expression<Func<VProductModelInstructions, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<VProductModelInstructions,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VProductModelInstructions" />.
    /// </summary>
     public async Task<Result<VProductModelInstructionsReadModel>> CreateAsync(
       VProductModelInstructionsCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new VProductModelInstructionsCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VProductModelInstructions" />.
    /// </summary>
     public async Task<Result<VProductModelInstructionsReadModel>> UpdateAsync(
       int id,
       VProductModelInstructionsUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new VProductModelInstructionsUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VProductModelInstructions" />.
    /// </summary>
      public virtual async Task<Result<VProductModelInstructionsReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new VProductModelInstructionsDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IVProductModelInstructionsRepository
    : IRepository<VProductModelInstructions,int, VProductModelInstructionsReadModel, VProductModelInstructionsCreateModel, VProductModelInstructionsUpdateModel>
{
}

