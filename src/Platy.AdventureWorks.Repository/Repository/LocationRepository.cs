using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;
using Platy.Shared;
using FluentValidation;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using MediatR;


namespace Platy.AdventureWorks.Repository;

/// <summary>
/// Repository class representing data for table 'Location'.
/// </summary>
[RegisterScoped]
public class LocationRepository
    : EntityRepository<Location,short, LocationReadModel, LocationCreateModel, LocationUpdateModel>, ILocationRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationRepository"/> class.
    /// </summary>
    public LocationRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<LocationRepository> logger,
        IValidator<LocationCreateModel> createValidator,
        IValidator<LocationUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="LocationReadModel" />.
    /// </summary>
    public async Task<Result<LocationReadModel>> GetAsync(short id,
      CancellationToken cancellationToken) =>
      await ReadModel<Location, short>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="LocationReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<LocationReadModel>>> ListAsync(
       Expression<Func<Location, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<Location,short>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Location" />.
    /// </summary>
     public async Task<Result<LocationReadModel>> CreateAsync(
       LocationCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new LocationCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Location" />.
    /// </summary>
     public async Task<Result<LocationReadModel>> UpdateAsync(
       short id,
       LocationUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new LocationUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Location" />.
    /// </summary>
      public virtual async Task<Result<LocationReadModel>> DeleteAsync(
       short id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new LocationDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface ILocationRepository
    : IRepository<Location,short, LocationReadModel, LocationCreateModel, LocationUpdateModel>
{
}

