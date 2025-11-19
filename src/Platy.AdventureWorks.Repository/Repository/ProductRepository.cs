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
///   Repository class representing data for table 'Product'.
/// </summary>
[RegisterScoped]
public class ProductRepository
  : EntityRepository<Product, int, ProductReadModel, ProductCreateModel, ProductUpdateModel>, IProductRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductRepository" /> class.
  /// </summary>
  public ProductRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ProductRepository> logger,
    IValidator<ProductCreateModel> createValidator,
    IValidator<ProductUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ProductReadModel" />.
  /// </summary>
  public async Task<Result<ProductReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<Product, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ProductReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ProductReadModel>>> ListAsync(
    Expression<Func<Product, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<Product, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="Product" />.
  /// </summary>
  public async Task<Result<ProductReadModel>> CreateAsync(
    ProductCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ProductCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="Product" />.
  /// </summary>
  public async Task<Result<ProductReadModel>> UpdateAsync(
    int id,
    ProductUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ProductUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="Product" />.
  /// </summary>
  public virtual async Task<Result<ProductReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ProductDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IProductRepository
  : IRepository<Product, int, ProductReadModel, ProductCreateModel, ProductUpdateModel>
{
}
