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
///   Repository class representing data for table 'Shift'.
/// </summary>
[RegisterScoped]
public class ShiftRepository
  : EntityRepository<Shift, byte, ShiftReadModel, ShiftCreateModel, ShiftUpdateModel>, IShiftRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShiftRepository" /> class.
  /// </summary>
  public ShiftRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ShiftRepository> logger,
    IValidator<ShiftCreateModel> createValidator,
    IValidator<ShiftUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ShiftReadModel" />.
  /// </summary>
  public async Task<Result<ShiftReadModel>> GetAsync(byte id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<Shift, byte>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ShiftReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ShiftReadModel>>> ListAsync(
    Expression<Func<Shift, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<Shift, byte>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="Shift" />.
  /// </summary>
  public async Task<Result<ShiftReadModel>> CreateAsync(
    ShiftCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ShiftCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="Shift" />.
  /// </summary>
  public async Task<Result<ShiftReadModel>> UpdateAsync(
    byte id,
    ShiftUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ShiftUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="Shift" />.
  /// </summary>
  public virtual async Task<Result<ShiftReadModel>> DeleteAsync(
    byte id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ShiftDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IShiftRepository
  : IRepository<Shift, byte, ShiftReadModel, ShiftCreateModel, ShiftUpdateModel>
{
}
