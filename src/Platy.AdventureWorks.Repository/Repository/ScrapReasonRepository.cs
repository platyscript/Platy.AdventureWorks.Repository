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
///   Repository class representing data for table 'ScrapReason'.
/// </summary>
[RegisterScoped]
public class ScrapReasonRepository
  : EntityRepository<ScrapReason, short, ScrapReasonReadModel, ScrapReasonCreateModel, ScrapReasonUpdateModel>,
    IScrapReasonRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ScrapReasonRepository" /> class.
  /// </summary>
  public ScrapReasonRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ScrapReasonRepository> logger,
    IValidator<ScrapReasonCreateModel> createValidator,
    IValidator<ScrapReasonUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ScrapReasonReadModel" />.
  /// </summary>
  public async Task<Result<ScrapReasonReadModel>> GetAsync(short id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ScrapReason, short>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ScrapReasonReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ScrapReasonReadModel>>> ListAsync(
    Expression<Func<ScrapReason, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ScrapReason, short>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ScrapReason" />.
  /// </summary>
  public async Task<Result<ScrapReasonReadModel>> CreateAsync(
    ScrapReasonCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ScrapReasonCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ScrapReason" />.
  /// </summary>
  public async Task<Result<ScrapReasonReadModel>> UpdateAsync(
    short id,
    ScrapReasonUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ScrapReasonUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ScrapReason" />.
  /// </summary>
  public virtual async Task<Result<ScrapReasonReadModel>> DeleteAsync(
    short id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ScrapReasonDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IScrapReasonRepository
  : IRepository<ScrapReason, short, ScrapReasonReadModel, ScrapReasonCreateModel, ScrapReasonUpdateModel>
{
}
