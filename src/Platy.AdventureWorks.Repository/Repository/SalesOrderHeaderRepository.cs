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
///   Repository class representing data for table 'SalesOrderHeader'.
/// </summary>
[RegisterScoped]
public class SalesOrderHeaderRepository
  : EntityRepository<SalesOrderHeader, int, SalesOrderHeaderReadModel, SalesOrderHeaderCreateModel,
    SalesOrderHeaderUpdateModel>, ISalesOrderHeaderRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeaderRepository" /> class.
  /// </summary>
  public SalesOrderHeaderRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<SalesOrderHeaderRepository> logger,
    IValidator<SalesOrderHeaderCreateModel> createValidator,
    IValidator<SalesOrderHeaderUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="SalesOrderHeaderReadModel" />.
  /// </summary>
  public async Task<Result<SalesOrderHeaderReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<SalesOrderHeader, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="SalesOrderHeaderReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<SalesOrderHeaderReadModel>>> ListAsync(
    Expression<Func<SalesOrderHeader, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<SalesOrderHeader, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="SalesOrderHeader" />.
  /// </summary>
  public async Task<Result<SalesOrderHeaderReadModel>> CreateAsync(
    SalesOrderHeaderCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new SalesOrderHeaderCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="SalesOrderHeader" />.
  /// </summary>
  public async Task<Result<SalesOrderHeaderReadModel>> UpdateAsync(
    int id,
    SalesOrderHeaderUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new SalesOrderHeaderUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="SalesOrderHeader" />.
  /// </summary>
  public virtual async Task<Result<SalesOrderHeaderReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new SalesOrderHeaderDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ISalesOrderHeaderRepository
  : IRepository<SalesOrderHeader, int, SalesOrderHeaderReadModel, SalesOrderHeaderCreateModel,
    SalesOrderHeaderUpdateModel>
{
}
