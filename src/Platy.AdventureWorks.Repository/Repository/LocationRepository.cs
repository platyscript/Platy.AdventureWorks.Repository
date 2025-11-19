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
///   Repository class representing data for table 'Location'.
/// </summary>
[RegisterScoped]
public class LocationRepository
  : EntityRepository<Location, short, LocationReadModel, LocationCreateModel, LocationUpdateModel>, ILocationRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="LocationRepository" /> class.
  /// </summary>
  public LocationRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<LocationRepository> logger,
    IValidator<LocationCreateModel> createValidator,
    IValidator<LocationUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="LocationReadModel" />.
  /// </summary>
  public async Task<Result<LocationReadModel>> GetAsync(short id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<Location, short>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="LocationReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<LocationReadModel>>> ListAsync(
    Expression<Func<Location, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<Location, short>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="Location" />.
  /// </summary>
  public async Task<Result<LocationReadModel>> CreateAsync(
    LocationCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new LocationCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="Location" />.
  /// </summary>
  public async Task<Result<LocationReadModel>> UpdateAsync(
    short id,
    LocationUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new LocationUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="Location" />.
  /// </summary>
  public virtual async Task<Result<LocationReadModel>> DeleteAsync(
    short id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new LocationDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ILocationRepository
  : IRepository<Location, short, LocationReadModel, LocationCreateModel, LocationUpdateModel>
{
}
