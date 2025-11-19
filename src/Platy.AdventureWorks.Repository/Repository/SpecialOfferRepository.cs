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
///   Repository class representing data for table 'SpecialOffer'.
/// </summary>
[RegisterScoped]
public class SpecialOfferRepository
  : EntityRepository<SpecialOffer, int, SpecialOfferReadModel, SpecialOfferCreateModel, SpecialOfferUpdateModel>,
    ISpecialOfferRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SpecialOfferRepository" /> class.
  /// </summary>
  public SpecialOfferRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<SpecialOfferRepository> logger,
    IValidator<SpecialOfferCreateModel> createValidator,
    IValidator<SpecialOfferUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="SpecialOfferReadModel" />.
  /// </summary>
  public async Task<Result<SpecialOfferReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<SpecialOffer, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="SpecialOfferReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<SpecialOfferReadModel>>> ListAsync(
    Expression<Func<SpecialOffer, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<SpecialOffer, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="SpecialOffer" />.
  /// </summary>
  public async Task<Result<SpecialOfferReadModel>> CreateAsync(
    SpecialOfferCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new SpecialOfferCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="SpecialOffer" />.
  /// </summary>
  public async Task<Result<SpecialOfferReadModel>> UpdateAsync(
    int id,
    SpecialOfferUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new SpecialOfferUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="SpecialOffer" />.
  /// </summary>
  public virtual async Task<Result<SpecialOfferReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new SpecialOfferDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ISpecialOfferRepository
  : IRepository<SpecialOffer, int, SpecialOfferReadModel, SpecialOfferCreateModel, SpecialOfferUpdateModel>
{
}
