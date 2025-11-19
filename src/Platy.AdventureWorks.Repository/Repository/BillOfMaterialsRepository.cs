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
///   Repository class representing data for table 'BillOfMaterials'.
/// </summary>
[RegisterScoped]
public class BillOfMaterialsRepository
  : EntityRepository<BillOfMaterials, int, BillOfMaterialsReadModel, BillOfMaterialsCreateModel,
    BillOfMaterialsUpdateModel>, IBillOfMaterialsRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BillOfMaterialsRepository" /> class.
  /// </summary>
  public BillOfMaterialsRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<BillOfMaterialsRepository> logger,
    IValidator<BillOfMaterialsCreateModel> createValidator,
    IValidator<BillOfMaterialsUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="BillOfMaterialsReadModel" />.
  /// </summary>
  public async Task<Result<BillOfMaterialsReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<BillOfMaterials, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="BillOfMaterialsReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<BillOfMaterialsReadModel>>> ListAsync(
    Expression<Func<BillOfMaterials, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<BillOfMaterials, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="BillOfMaterials" />.
  /// </summary>
  public async Task<Result<BillOfMaterialsReadModel>> CreateAsync(
    BillOfMaterialsCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new BillOfMaterialsCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="BillOfMaterials" />.
  /// </summary>
  public async Task<Result<BillOfMaterialsReadModel>> UpdateAsync(
    int id,
    BillOfMaterialsUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new BillOfMaterialsUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="BillOfMaterials" />.
  /// </summary>
  public virtual async Task<Result<BillOfMaterialsReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new BillOfMaterialsDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IBillOfMaterialsRepository
  : IRepository<BillOfMaterials, int, BillOfMaterialsReadModel, BillOfMaterialsCreateModel, BillOfMaterialsUpdateModel>
{
}
