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
///   Repository class representing data for table 'SalesOrderDetail'.
/// </summary>
[RegisterScoped]
public class SalesOrderDetailRepository
  : EntityRepository<SalesOrderDetail, int, SalesOrderDetailReadModel, SalesOrderDetailCreateModel,
    SalesOrderDetailUpdateModel>, ISalesOrderDetailRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderDetailRepository" /> class.
  /// </summary>
  public SalesOrderDetailRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<SalesOrderDetailRepository> logger,
    IValidator<SalesOrderDetailCreateModel> createValidator,
    IValidator<SalesOrderDetailUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="SalesOrderDetailReadModel" />.
  /// </summary>
  public async Task<Result<SalesOrderDetailReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<SalesOrderDetail, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="SalesOrderDetailReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<SalesOrderDetailReadModel>>> ListAsync(
    Expression<Func<SalesOrderDetail, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<SalesOrderDetail, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="SalesOrderDetail" />.
  /// </summary>
  public async Task<Result<SalesOrderDetailReadModel>> CreateAsync(
    SalesOrderDetailCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new SalesOrderDetailCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="SalesOrderDetail" />.
  /// </summary>
  public async Task<Result<SalesOrderDetailReadModel>> UpdateAsync(
    int id,
    SalesOrderDetailUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new SalesOrderDetailUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="SalesOrderDetail" />.
  /// </summary>
  public virtual async Task<Result<SalesOrderDetailReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new SalesOrderDetailDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ISalesOrderDetailRepository
  : IRepository<SalesOrderDetail, int, SalesOrderDetailReadModel, SalesOrderDetailCreateModel,
    SalesOrderDetailUpdateModel>
{
}
