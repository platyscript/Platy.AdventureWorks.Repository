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
///   Repository class representing data for table 'ProductCategory'.
/// </summary>
[RegisterScoped]
public class ProductCategoryRepository
  : EntityRepository<ProductCategory, int, ProductCategoryReadModel, ProductCategoryCreateModel,
    ProductCategoryUpdateModel>, IProductCategoryRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductCategoryRepository" /> class.
  /// </summary>
  public ProductCategoryRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ProductCategoryRepository> logger,
    IValidator<ProductCategoryCreateModel> createValidator,
    IValidator<ProductCategoryUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ProductCategoryReadModel" />.
  /// </summary>
  public async Task<Result<ProductCategoryReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ProductCategory, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ProductCategoryReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ProductCategoryReadModel>>> ListAsync(
    Expression<Func<ProductCategory, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ProductCategory, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ProductCategory" />.
  /// </summary>
  public async Task<Result<ProductCategoryReadModel>> CreateAsync(
    ProductCategoryCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ProductCategoryCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ProductCategory" />.
  /// </summary>
  public async Task<Result<ProductCategoryReadModel>> UpdateAsync(
    int id,
    ProductCategoryUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ProductCategoryUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ProductCategory" />.
  /// </summary>
  public virtual async Task<Result<ProductCategoryReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ProductCategoryDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IProductCategoryRepository
  : IRepository<ProductCategory, int, ProductCategoryReadModel, ProductCategoryCreateModel, ProductCategoryUpdateModel>
{
}
