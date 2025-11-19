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
///   Repository class representing data for table 'StateProvince'.
/// </summary>
[RegisterScoped]
public class StateProvinceRepository
  : EntityRepository<StateProvince, int, StateProvinceReadModel, StateProvinceCreateModel, StateProvinceUpdateModel>,
    IStateProvinceRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="StateProvinceRepository" /> class.
  /// </summary>
  public StateProvinceRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<StateProvinceRepository> logger,
    IValidator<StateProvinceCreateModel> createValidator,
    IValidator<StateProvinceUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="StateProvinceReadModel" />.
  /// </summary>
  public async Task<Result<StateProvinceReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<StateProvince, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="StateProvinceReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<StateProvinceReadModel>>> ListAsync(
    Expression<Func<StateProvince, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<StateProvince, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="StateProvince" />.
  /// </summary>
  public async Task<Result<StateProvinceReadModel>> CreateAsync(
    StateProvinceCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new StateProvinceCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="StateProvince" />.
  /// </summary>
  public async Task<Result<StateProvinceReadModel>> UpdateAsync(
    int id,
    StateProvinceUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new StateProvinceUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="StateProvince" />.
  /// </summary>
  public virtual async Task<Result<StateProvinceReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new StateProvinceDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IStateProvinceRepository
  : IRepository<StateProvince, int, StateProvinceReadModel, StateProvinceCreateModel, StateProvinceUpdateModel>
{
}
