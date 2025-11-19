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
///   Repository class representing data for table 'ShipMethod'.
/// </summary>
[RegisterScoped]
public class ShipMethodRepository
  : EntityRepository<ShipMethod, int, ShipMethodReadModel, ShipMethodCreateModel, ShipMethodUpdateModel>,
    IShipMethodRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShipMethodRepository" /> class.
  /// </summary>
  public ShipMethodRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ShipMethodRepository> logger,
    IValidator<ShipMethodCreateModel> createValidator,
    IValidator<ShipMethodUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ShipMethodReadModel" />.
  /// </summary>
  public async Task<Result<ShipMethodReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ShipMethod, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ShipMethodReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ShipMethodReadModel>>> ListAsync(
    Expression<Func<ShipMethod, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ShipMethod, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ShipMethod" />.
  /// </summary>
  public async Task<Result<ShipMethodReadModel>> CreateAsync(
    ShipMethodCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ShipMethodCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ShipMethod" />.
  /// </summary>
  public async Task<Result<ShipMethodReadModel>> UpdateAsync(
    int id,
    ShipMethodUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ShipMethodUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ShipMethod" />.
  /// </summary>
  public virtual async Task<Result<ShipMethodReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ShipMethodDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IShipMethodRepository
  : IRepository<ShipMethod, int, ShipMethodReadModel, ShipMethodCreateModel, ShipMethodUpdateModel>
{
}
