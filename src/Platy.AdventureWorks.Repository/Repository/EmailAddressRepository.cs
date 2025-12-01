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
/// Repository class representing data for table 'EmailAddress'.
/// </summary>
[RegisterScoped]
public class EmailAddressRepository
    : EntityRepository<EmailAddress,int, EmailAddressReadModel, EmailAddressCreateModel, EmailAddressUpdateModel>, IEmailAddressRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAddressRepository"/> class.
    /// </summary>
    public EmailAddressRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<EmailAddressRepository> logger,
        IValidator<EmailAddressCreateModel> createValidator,
        IValidator<EmailAddressUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="EmailAddressReadModel" />.
    /// </summary>
    public async Task<Result<EmailAddressReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<EmailAddress, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="EmailAddressReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<EmailAddressReadModel>>> ListAsync(
       Expression<Func<EmailAddress, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<EmailAddress,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="EmailAddress" />.
    /// </summary>
     public async Task<Result<EmailAddressReadModel>> CreateAsync(
       EmailAddressCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new EmailAddressCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="EmailAddress" />.
    /// </summary>
     public async Task<Result<EmailAddressReadModel>> UpdateAsync(
       int id,
       EmailAddressUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new EmailAddressUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="EmailAddress" />.
    /// </summary>
      public virtual async Task<Result<EmailAddressReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new EmailAddressDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IEmailAddressRepository
    : IRepository<EmailAddress,int, EmailAddressReadModel, EmailAddressCreateModel, EmailAddressUpdateModel>
{
}

