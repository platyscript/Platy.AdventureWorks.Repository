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
///   Repository class representing data for table 'SalesTaxRate'.
/// </summary>
[RegisterScoped]
public class SalesTaxRateRepository
  : EntityRepository<SalesTaxRate, int, SalesTaxRateReadModel, SalesTaxRateCreateModel, SalesTaxRateUpdateModel>,
    ISalesTaxRateRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTaxRateRepository" /> class.
  /// </summary>
  public SalesTaxRateRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<SalesTaxRateRepository> logger,
    IValidator<SalesTaxRateCreateModel> createValidator,
    IValidator<SalesTaxRateUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="SalesTaxRateReadModel" />.
  /// </summary>
  public async Task<Result<SalesTaxRateReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<SalesTaxRate, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="SalesTaxRateReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<SalesTaxRateReadModel>>> ListAsync(
    Expression<Func<SalesTaxRate, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<SalesTaxRate, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="SalesTaxRate" />.
  /// </summary>
  public async Task<Result<SalesTaxRateReadModel>> CreateAsync(
    SalesTaxRateCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new SalesTaxRateCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="SalesTaxRate" />.
  /// </summary>
  public async Task<Result<SalesTaxRateReadModel>> UpdateAsync(
    int id,
    SalesTaxRateUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new SalesTaxRateUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="SalesTaxRate" />.
  /// </summary>
  public virtual async Task<Result<SalesTaxRateReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new SalesTaxRateDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ISalesTaxRateRepository
  : IRepository<SalesTaxRate, int, SalesTaxRateReadModel, SalesTaxRateCreateModel, SalesTaxRateUpdateModel>
{
}
