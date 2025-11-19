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
///   Repository class representing data for table 'CreditCard'.
/// </summary>
[RegisterScoped]
public class CreditCardRepository
  : EntityRepository<CreditCard, int, CreditCardReadModel, CreditCardCreateModel, CreditCardUpdateModel>,
    ICreditCardRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CreditCardRepository" /> class.
  /// </summary>
  public CreditCardRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<CreditCardRepository> logger,
    IValidator<CreditCardCreateModel> createValidator,
    IValidator<CreditCardUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="CreditCardReadModel" />.
  /// </summary>
  public async Task<Result<CreditCardReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<CreditCard, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="CreditCardReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<CreditCardReadModel>>> ListAsync(
    Expression<Func<CreditCard, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<CreditCard, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="CreditCard" />.
  /// </summary>
  public async Task<Result<CreditCardReadModel>> CreateAsync(
    CreditCardCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new CreditCardCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="CreditCard" />.
  /// </summary>
  public async Task<Result<CreditCardReadModel>> UpdateAsync(
    int id,
    CreditCardUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new CreditCardUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="CreditCard" />.
  /// </summary>
  public virtual async Task<Result<CreditCardReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new CreditCardDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ICreditCardRepository
  : IRepository<CreditCard, int, CreditCardReadModel, CreditCardCreateModel, CreditCardUpdateModel>
{
}
