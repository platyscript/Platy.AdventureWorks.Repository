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
/// Repository class representing data for table 'AddressType'.
/// </summary>
[RegisterScoped]
public class AddressTypeRepository
    : EntityRepository<AddressType,int, AddressTypeReadModel, AddressTypeCreateModel, AddressTypeUpdateModel>, IAddressTypeRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressTypeRepository"/> class.
    /// </summary>
    public AddressTypeRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<AddressTypeRepository> logger,
        IValidator<AddressTypeCreateModel> createValidator,
        IValidator<AddressTypeUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="AddressTypeReadModel" />.
    /// </summary>
    public async Task<Result<AddressTypeReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<AddressType, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="AddressTypeReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<AddressTypeReadModel>>> ListAsync(
       Expression<Func<AddressType, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<AddressType,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="AddressType" />.
    /// </summary>
     public async Task<Result<AddressTypeReadModel>> CreateAsync(
       AddressTypeCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new AddressTypeCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="AddressType" />.
    /// </summary>
     public async Task<Result<AddressTypeReadModel>> UpdateAsync(
       int id,
       AddressTypeUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new AddressTypeUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="AddressType" />.
    /// </summary>
      public virtual async Task<Result<AddressTypeReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new AddressTypeDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IAddressTypeRepository
    : IRepository<AddressType,int, AddressTypeReadModel, AddressTypeCreateModel, AddressTypeUpdateModel>
{
}

