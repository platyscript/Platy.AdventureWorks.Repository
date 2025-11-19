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
///   Repository class representing data for table 'SalesTerritory'.
/// </summary>
[RegisterScoped]
public class SalesTerritoryRepository
  : EntityRepository<SalesTerritory, int, SalesTerritoryReadModel, SalesTerritoryCreateModel,
    SalesTerritoryUpdateModel>, ISalesTerritoryRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTerritoryRepository" /> class.
  /// </summary>
  public SalesTerritoryRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<SalesTerritoryRepository> logger,
    IValidator<SalesTerritoryCreateModel> createValidator,
    IValidator<SalesTerritoryUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="SalesTerritoryReadModel" />.
  /// </summary>
  public async Task<Result<SalesTerritoryReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<SalesTerritory, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="SalesTerritoryReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<SalesTerritoryReadModel>>> ListAsync(
    Expression<Func<SalesTerritory, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<SalesTerritory, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="SalesTerritory" />.
  /// </summary>
  public async Task<Result<SalesTerritoryReadModel>> CreateAsync(
    SalesTerritoryCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new SalesTerritoryCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="SalesTerritory" />.
  /// </summary>
  public async Task<Result<SalesTerritoryReadModel>> UpdateAsync(
    int id,
    SalesTerritoryUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new SalesTerritoryUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="SalesTerritory" />.
  /// </summary>
  public virtual async Task<Result<SalesTerritoryReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new SalesTerritoryDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ISalesTerritoryRepository
  : IRepository<SalesTerritory, int, SalesTerritoryReadModel, SalesTerritoryCreateModel, SalesTerritoryUpdateModel>
{
}
