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
/// Repository class representing data for table 'ShipMethod'.
/// </summary>
[RegisterScoped]
public class ShipMethodRepository
    : EntityRepository<ShipMethod,int, ShipMethodReadModel, ShipMethodCreateModel, ShipMethodUpdateModel>, IShipMethodRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodRepository"/> class.
    /// </summary>
    public ShipMethodRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ShipMethodRepository> logger,
        IValidator<ShipMethodCreateModel> createValidator,
        IValidator<ShipMethodUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ShipMethodReadModel" />.
    /// </summary>
    public async Task<Result<ShipMethodReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ShipMethod, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ShipMethodReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ShipMethodReadModel>>> ListAsync(
       Expression<Func<ShipMethod, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<ShipMethod,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ShipMethod" />.
    /// </summary>
     public async Task<Result<ShipMethodReadModel>> CreateAsync(
       ShipMethodCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new ShipMethodCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ShipMethod" />.
    /// </summary>
     public async Task<Result<ShipMethodReadModel>> UpdateAsync(
       int id,
       ShipMethodUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new ShipMethodUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ShipMethod" />.
    /// </summary>
      public virtual async Task<Result<ShipMethodReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new ShipMethodDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IShipMethodRepository
    : IRepository<ShipMethod,int, ShipMethodReadModel, ShipMethodCreateModel, ShipMethodUpdateModel>
{
}

