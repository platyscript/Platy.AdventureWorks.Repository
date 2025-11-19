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
///   Repository class representing data for table 'Illustration'.
/// </summary>
[RegisterScoped]
public class IllustrationRepository
  : EntityRepository<Illustration, int, IllustrationReadModel, IllustrationCreateModel, IllustrationUpdateModel>,
    IIllustrationRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="IllustrationRepository" /> class.
  /// </summary>
  public IllustrationRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<IllustrationRepository> logger,
    IValidator<IllustrationCreateModel> createValidator,
    IValidator<IllustrationUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="IllustrationReadModel" />.
  /// </summary>
  public async Task<Result<IllustrationReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<Illustration, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="IllustrationReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<IllustrationReadModel>>> ListAsync(
    Expression<Func<Illustration, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<Illustration, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="Illustration" />.
  /// </summary>
  public async Task<Result<IllustrationReadModel>> CreateAsync(
    IllustrationCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new IllustrationCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="Illustration" />.
  /// </summary>
  public async Task<Result<IllustrationReadModel>> UpdateAsync(
    int id,
    IllustrationUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new IllustrationUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="Illustration" />.
  /// </summary>
  public virtual async Task<Result<IllustrationReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new IllustrationDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IIllustrationRepository
  : IRepository<Illustration, int, IllustrationReadModel, IllustrationCreateModel, IllustrationUpdateModel>
{
}
