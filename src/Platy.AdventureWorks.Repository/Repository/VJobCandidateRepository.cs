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
///   Repository class representing data for table 'vJobCandidate'.
/// </summary>
[RegisterScoped]
public class VJobCandidateRepository
  : EntityRepository<VJobCandidate, int, VJobCandidateReadModel, VJobCandidateCreateModel, VJobCandidateUpdateModel>,
    IVJobCandidateRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateRepository" /> class.
  /// </summary>
  public VJobCandidateRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<VJobCandidateRepository> logger,
    IValidator<VJobCandidateCreateModel> createValidator,
    IValidator<VJobCandidateUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="VJobCandidateReadModel" />.
  /// </summary>
  public async Task<Result<VJobCandidateReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<VJobCandidate, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="VJobCandidateReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<VJobCandidateReadModel>>> ListAsync(
    Expression<Func<VJobCandidate, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<VJobCandidate, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="VJobCandidate" />.
  /// </summary>
  public async Task<Result<VJobCandidateReadModel>> CreateAsync(
    VJobCandidateCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new VJobCandidateCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="VJobCandidate" />.
  /// </summary>
  public async Task<Result<VJobCandidateReadModel>> UpdateAsync(
    int id,
    VJobCandidateUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new VJobCandidateUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="VJobCandidate" />.
  /// </summary>
  public virtual async Task<Result<VJobCandidateReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new VJobCandidateDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IVJobCandidateRepository
  : IRepository<VJobCandidate, int, VJobCandidateReadModel, VJobCandidateCreateModel, VJobCandidateUpdateModel>
{
}
