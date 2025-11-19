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
///   Repository class representing data for table 'TransactionHistory'.
/// </summary>
[RegisterScoped]
public class TransactionHistoryRepository
  : EntityRepository<TransactionHistory, int, TransactionHistoryReadModel, TransactionHistoryCreateModel,
    TransactionHistoryUpdateModel>, ITransactionHistoryRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="TransactionHistoryRepository" /> class.
  /// </summary>
  public TransactionHistoryRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<TransactionHistoryRepository> logger,
    IValidator<TransactionHistoryCreateModel> createValidator,
    IValidator<TransactionHistoryUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="TransactionHistoryReadModel" />.
  /// </summary>
  public async Task<Result<TransactionHistoryReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<TransactionHistory, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="TransactionHistoryReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<TransactionHistoryReadModel>>> ListAsync(
    Expression<Func<TransactionHistory, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<TransactionHistory, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="TransactionHistory" />.
  /// </summary>
  public async Task<Result<TransactionHistoryReadModel>> CreateAsync(
    TransactionHistoryCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new TransactionHistoryCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="TransactionHistory" />.
  /// </summary>
  public async Task<Result<TransactionHistoryReadModel>> UpdateAsync(
    int id,
    TransactionHistoryUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new TransactionHistoryUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="TransactionHistory" />.
  /// </summary>
  public virtual async Task<Result<TransactionHistoryReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new TransactionHistoryDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ITransactionHistoryRepository
  : IRepository<TransactionHistory, int, TransactionHistoryReadModel, TransactionHistoryCreateModel,
    TransactionHistoryUpdateModel>
{
}
