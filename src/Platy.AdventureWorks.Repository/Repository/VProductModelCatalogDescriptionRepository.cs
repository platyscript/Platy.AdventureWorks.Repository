using System.Linq.Expressions;
using Ardalis.Result;
using FluentValidation;
using MediatR;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;

namespace Platy.AdventureWorks.Repository;

/// <summary>
///   Repository class representing data for table 'vProductModelCatalogDescription'.
/// </summary>
[RegisterScoped]
public class VProductModelCatalogDescriptionRepository
  : EntityRepository<VProductModelCatalogDescription, int, VProductModelCatalogDescriptionReadModel,
      VProductModelCatalogDescriptionCreateModel, VProductModelCatalogDescriptionUpdateModel>,
    IVProductModelCatalogDescriptionRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelCatalogDescriptionRepository" /> class.
  /// </summary>
  public VProductModelCatalogDescriptionRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<VProductModelCatalogDescriptionRepository> logger,
    IValidator<VProductModelCatalogDescriptionCreateModel> createValidator,
    IValidator<VProductModelCatalogDescriptionUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="VProductModelCatalogDescriptionReadModel" />.
  /// </summary>
  public async Task<Result<VProductModelCatalogDescriptionReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<VProductModelCatalogDescription, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="VProductModelCatalogDescriptionReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<VProductModelCatalogDescriptionReadModel>>> ListAsync(
    Expression<Func<VProductModelCatalogDescription, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<VProductModelCatalogDescription, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="VProductModelCatalogDescription" />.
  /// </summary>
  public async Task<Result<VProductModelCatalogDescriptionReadModel>> CreateAsync(
    VProductModelCatalogDescriptionCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new VProductModelCatalogDescriptionCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="VProductModelCatalogDescription" />.
  /// </summary>
  public async Task<Result<VProductModelCatalogDescriptionReadModel>> UpdateAsync(
    int id,
    VProductModelCatalogDescriptionUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new VProductModelCatalogDescriptionUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="VProductModelCatalogDescription" />.
  /// </summary>
  public virtual async Task<Result<VProductModelCatalogDescriptionReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new VProductModelCatalogDescriptionDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IVProductModelCatalogDescriptionRepository
  : IRepository<VProductModelCatalogDescription, int, VProductModelCatalogDescriptionReadModel,
    VProductModelCatalogDescriptionCreateModel, VProductModelCatalogDescriptionUpdateModel>
{
}
