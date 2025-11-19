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
///   Repository class representing data for table 'ProductModel'.
/// </summary>
[RegisterScoped]
public class ProductModelRepository
  : EntityRepository<ProductModel, int, ProductModelReadModel, ProductModelCreateModel, ProductModelUpdateModel>,
    IProductModelRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductModelRepository" /> class.
  /// </summary>
  public ProductModelRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ProductModelRepository> logger,
    IValidator<ProductModelCreateModel> createValidator,
    IValidator<ProductModelUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ProductModelReadModel" />.
  /// </summary>
  public async Task<Result<ProductModelReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ProductModel, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ProductModelReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ProductModelReadModel>>> ListAsync(
    Expression<Func<ProductModel, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ProductModel, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ProductModel" />.
  /// </summary>
  public async Task<Result<ProductModelReadModel>> CreateAsync(
    ProductModelCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ProductModelCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ProductModel" />.
  /// </summary>
  public async Task<Result<ProductModelReadModel>> UpdateAsync(
    int id,
    ProductModelUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ProductModelUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ProductModel" />.
  /// </summary>
  public virtual async Task<Result<ProductModelReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ProductModelDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IProductModelRepository
  : IRepository<ProductModel, int, ProductModelReadModel, ProductModelCreateModel, ProductModelUpdateModel>
{
}
