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
///   Repository class representing data for table 'BusinessEntity'.
/// </summary>
[RegisterScoped]
public class BusinessEntityRepository
  : EntityRepository<BusinessEntity, int, BusinessEntityReadModel, BusinessEntityCreateModel,
    BusinessEntityUpdateModel>, IBusinessEntityRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityRepository" /> class.
  /// </summary>
  public BusinessEntityRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<BusinessEntityRepository> logger,
    IValidator<BusinessEntityCreateModel> createValidator,
    IValidator<BusinessEntityUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="BusinessEntityReadModel" />.
  /// </summary>
  public async Task<Result<BusinessEntityReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<BusinessEntity, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="BusinessEntityReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<BusinessEntityReadModel>>> ListAsync(
    Expression<Func<BusinessEntity, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<BusinessEntity, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="BusinessEntity" />.
  /// </summary>
  public async Task<Result<BusinessEntityReadModel>> CreateAsync(
    BusinessEntityCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new BusinessEntityCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="BusinessEntity" />.
  /// </summary>
  public async Task<Result<BusinessEntityReadModel>> UpdateAsync(
    int id,
    BusinessEntityUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new BusinessEntityUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="BusinessEntity" />.
  /// </summary>
  public virtual async Task<Result<BusinessEntityReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new BusinessEntityDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IBusinessEntityRepository
  : IRepository<BusinessEntity, int, BusinessEntityReadModel, BusinessEntityCreateModel, BusinessEntityUpdateModel>
{
}
