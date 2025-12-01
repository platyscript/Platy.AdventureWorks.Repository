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
/// Repository class representing data for table 'Address'.
/// </summary>
[RegisterScoped]
public class AddressRepository
    : EntityRepository<Address,int, AddressReadModel, AddressCreateModel, AddressUpdateModel>, IAddressRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressRepository"/> class.
    /// </summary>
    public AddressRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<AddressRepository> logger,
        IValidator<AddressCreateModel> createValidator,
        IValidator<AddressUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="AddressReadModel" />.
    /// </summary>
    public async Task<Result<AddressReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<Address, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="AddressReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<AddressReadModel>>> ListAsync(
       Expression<Func<Address, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<Address,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Address" />.
    /// </summary>
     public async Task<Result<AddressReadModel>> CreateAsync(
       AddressCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new AddressCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Address" />.
    /// </summary>
     public async Task<Result<AddressReadModel>> UpdateAsync(
       int id,
       AddressUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new AddressUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Address" />.
    /// </summary>
      public virtual async Task<Result<AddressReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new AddressDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IAddressRepository
    : IRepository<Address,int, AddressReadModel, AddressCreateModel, AddressUpdateModel>
{
}

