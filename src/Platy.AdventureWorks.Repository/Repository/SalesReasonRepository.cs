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
///   Repository class representing data for table 'SalesReason'.
/// </summary>
[RegisterScoped]
public class SalesReasonRepository
  : EntityRepository<SalesReason, int, SalesReasonReadModel, SalesReasonCreateModel, SalesReasonUpdateModel>,
    ISalesReasonRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesReasonRepository" /> class.
  /// </summary>
  public SalesReasonRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<SalesReasonRepository> logger,
    IValidator<SalesReasonCreateModel> createValidator,
    IValidator<SalesReasonUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="SalesReasonReadModel" />.
  /// </summary>
  public async Task<Result<SalesReasonReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<SalesReason, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="SalesReasonReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<SalesReasonReadModel>>> ListAsync(
    Expression<Func<SalesReason, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<SalesReason, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="SalesReason" />.
  /// </summary>
  public async Task<Result<SalesReasonReadModel>> CreateAsync(
    SalesReasonCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new SalesReasonCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="SalesReason" />.
  /// </summary>
  public async Task<Result<SalesReasonReadModel>> UpdateAsync(
    int id,
    SalesReasonUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new SalesReasonUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="SalesReason" />.
  /// </summary>
  public virtual async Task<Result<SalesReasonReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new SalesReasonDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ISalesReasonRepository
  : IRepository<SalesReason, int, SalesReasonReadModel, SalesReasonCreateModel, SalesReasonUpdateModel>
{
}
