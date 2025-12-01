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
/// Repository class representing data for table 'vJobCandidate'.
/// </summary>
[RegisterScoped]
public class VJobCandidateRepository
    : EntityRepository<VJobCandidate,int, VJobCandidateReadModel, VJobCandidateCreateModel, VJobCandidateUpdateModel>, IVJobCandidateRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateRepository"/> class.
    /// </summary>
    public VJobCandidateRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VJobCandidateRepository> logger,
        IValidator<VJobCandidateCreateModel> createValidator,
        IValidator<VJobCandidateUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VJobCandidateReadModel" />.
    /// </summary>
    public async Task<Result<VJobCandidateReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VJobCandidate, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VJobCandidateReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VJobCandidateReadModel>>> ListAsync(
       Expression<Func<VJobCandidate, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<VJobCandidate,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VJobCandidate" />.
    /// </summary>
     public async Task<Result<VJobCandidateReadModel>> CreateAsync(
       VJobCandidateCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new VJobCandidateCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VJobCandidate" />.
    /// </summary>
     public async Task<Result<VJobCandidateReadModel>> UpdateAsync(
       int id,
       VJobCandidateUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new VJobCandidateUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VJobCandidate" />.
    /// </summary>
      public virtual async Task<Result<VJobCandidateReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new VJobCandidateDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IVJobCandidateRepository
    : IRepository<VJobCandidate,int, VJobCandidateReadModel, VJobCandidateCreateModel, VJobCandidateUpdateModel>
{
}

