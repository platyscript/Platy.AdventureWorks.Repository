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
/// Repository class representing data for table 'CurrencyRate'.
/// </summary>
[RegisterScoped]
public class CurrencyRateRepository
    : EntityRepository<CurrencyRate,int, CurrencyRateReadModel, CurrencyRateCreateModel, CurrencyRateUpdateModel>, ICurrencyRateRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRateRepository"/> class.
    /// </summary>
    public CurrencyRateRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<CurrencyRateRepository> logger,
        IValidator<CurrencyRateCreateModel> createValidator,
        IValidator<CurrencyRateUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="CurrencyRateReadModel" />.
    /// </summary>
    public async Task<Result<CurrencyRateReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<CurrencyRate, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="CurrencyRateReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<CurrencyRateReadModel>>> ListAsync(
       Expression<Func<CurrencyRate, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<CurrencyRate,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="CurrencyRate" />.
    /// </summary>
     public async Task<Result<CurrencyRateReadModel>> CreateAsync(
       CurrencyRateCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new CurrencyRateCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="CurrencyRate" />.
    /// </summary>
     public async Task<Result<CurrencyRateReadModel>> UpdateAsync(
       int id,
       CurrencyRateUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new CurrencyRateUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="CurrencyRate" />.
    /// </summary>
      public virtual async Task<Result<CurrencyRateReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new CurrencyRateDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface ICurrencyRateRepository
    : IRepository<CurrencyRate,int, CurrencyRateReadModel, CurrencyRateCreateModel, CurrencyRateUpdateModel>
{
}

