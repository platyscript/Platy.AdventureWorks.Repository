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
/// Repository class representing data for table 'vProductModelCatalogDescription'.
/// </summary>
[RegisterScoped]
public class VProductModelCatalogDescriptionRepository
    : EntityRepository<VProductModelCatalogDescription,int, VProductModelCatalogDescriptionReadModel, VProductModelCatalogDescriptionCreateModel, VProductModelCatalogDescriptionUpdateModel>, IVProductModelCatalogDescriptionRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelCatalogDescriptionRepository"/> class.
    /// </summary>
    public VProductModelCatalogDescriptionRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VProductModelCatalogDescriptionRepository> logger,
        IValidator<VProductModelCatalogDescriptionCreateModel> createValidator,
        IValidator<VProductModelCatalogDescriptionUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VProductModelCatalogDescriptionReadModel" />.
    /// </summary>
    public async Task<Result<VProductModelCatalogDescriptionReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VProductModelCatalogDescription, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VProductModelCatalogDescriptionReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VProductModelCatalogDescriptionReadModel>>> ListAsync(
       Expression<Func<VProductModelCatalogDescription, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<VProductModelCatalogDescription,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VProductModelCatalogDescription" />.
    /// </summary>
     public async Task<Result<VProductModelCatalogDescriptionReadModel>> CreateAsync(
       VProductModelCatalogDescriptionCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new VProductModelCatalogDescriptionCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VProductModelCatalogDescription" />.
    /// </summary>
     public async Task<Result<VProductModelCatalogDescriptionReadModel>> UpdateAsync(
       int id,
       VProductModelCatalogDescriptionUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new VProductModelCatalogDescriptionUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VProductModelCatalogDescription" />.
    /// </summary>
      public virtual async Task<Result<VProductModelCatalogDescriptionReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new VProductModelCatalogDescriptionDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IVProductModelCatalogDescriptionRepository
    : IRepository<VProductModelCatalogDescription,int, VProductModelCatalogDescriptionReadModel, VProductModelCatalogDescriptionCreateModel, VProductModelCatalogDescriptionUpdateModel>
{
}

