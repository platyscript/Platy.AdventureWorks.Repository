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
/// Repository class representing data for table 'ContactType'.
/// </summary>
[RegisterScoped]
public class ContactTypeRepository
    : EntityRepository<ContactType,int, ContactTypeReadModel, ContactTypeCreateModel, ContactTypeUpdateModel>, IContactTypeRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactTypeRepository"/> class.
    /// </summary>
    public ContactTypeRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ContactTypeRepository> logger,
        IValidator<ContactTypeCreateModel> createValidator,
        IValidator<ContactTypeUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ContactTypeReadModel" />.
    /// </summary>
    public async Task<Result<ContactTypeReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ContactType, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ContactTypeReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ContactTypeReadModel>>> ListAsync(
       Expression<Func<ContactType, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<ContactType,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ContactType" />.
    /// </summary>
     public async Task<Result<ContactTypeReadModel>> CreateAsync(
       ContactTypeCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new ContactTypeCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ContactType" />.
    /// </summary>
     public async Task<Result<ContactTypeReadModel>> UpdateAsync(
       int id,
       ContactTypeUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new ContactTypeUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ContactType" />.
    /// </summary>
      public virtual async Task<Result<ContactTypeReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new ContactTypeDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IContactTypeRepository
    : IRepository<ContactType,int, ContactTypeReadModel, ContactTypeCreateModel, ContactTypeUpdateModel>
{
}

