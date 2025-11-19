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
///   Repository class representing data for table 'PurchaseOrderDetail'.
/// </summary>
[RegisterScoped]
public class PurchaseOrderDetailRepository
  : EntityRepository<PurchaseOrderDetail, int, PurchaseOrderDetailReadModel, PurchaseOrderDetailCreateModel,
    PurchaseOrderDetailUpdateModel>, IPurchaseOrderDetailRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderDetailRepository" /> class.
  /// </summary>
  public PurchaseOrderDetailRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<PurchaseOrderDetailRepository> logger,
    IValidator<PurchaseOrderDetailCreateModel> createValidator,
    IValidator<PurchaseOrderDetailUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="PurchaseOrderDetailReadModel" />.
  /// </summary>
  public async Task<Result<PurchaseOrderDetailReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<PurchaseOrderDetail, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="PurchaseOrderDetailReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<PurchaseOrderDetailReadModel>>> ListAsync(
    Expression<Func<PurchaseOrderDetail, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<PurchaseOrderDetail, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="PurchaseOrderDetail" />.
  /// </summary>
  public async Task<Result<PurchaseOrderDetailReadModel>> CreateAsync(
    PurchaseOrderDetailCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new PurchaseOrderDetailCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="PurchaseOrderDetail" />.
  /// </summary>
  public async Task<Result<PurchaseOrderDetailReadModel>> UpdateAsync(
    int id,
    PurchaseOrderDetailUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new PurchaseOrderDetailUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="PurchaseOrderDetail" />.
  /// </summary>
  public virtual async Task<Result<PurchaseOrderDetailReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new PurchaseOrderDetailDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IPurchaseOrderDetailRepository
  : IRepository<PurchaseOrderDetail, int, PurchaseOrderDetailReadModel, PurchaseOrderDetailCreateModel,
    PurchaseOrderDetailUpdateModel>
{
}
