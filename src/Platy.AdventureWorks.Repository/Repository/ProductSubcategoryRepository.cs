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
///   Repository class representing data for table 'ProductSubcategory'.
/// </summary>
[RegisterScoped]
public class ProductSubcategoryRepository
  : EntityRepository<ProductSubcategory, int, ProductSubcategoryReadModel, ProductSubcategoryCreateModel,
    ProductSubcategoryUpdateModel>, IProductSubcategoryRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductSubcategoryRepository" /> class.
  /// </summary>
  public ProductSubcategoryRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ProductSubcategoryRepository> logger,
    IValidator<ProductSubcategoryCreateModel> createValidator,
    IValidator<ProductSubcategoryUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ProductSubcategoryReadModel" />.
  /// </summary>
  public async Task<Result<ProductSubcategoryReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ProductSubcategory, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ProductSubcategoryReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ProductSubcategoryReadModel>>> ListAsync(
    Expression<Func<ProductSubcategory, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ProductSubcategory, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ProductSubcategory" />.
  /// </summary>
  public async Task<Result<ProductSubcategoryReadModel>> CreateAsync(
    ProductSubcategoryCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ProductSubcategoryCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ProductSubcategory" />.
  /// </summary>
  public async Task<Result<ProductSubcategoryReadModel>> UpdateAsync(
    int id,
    ProductSubcategoryUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ProductSubcategoryUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ProductSubcategory" />.
  /// </summary>
  public virtual async Task<Result<ProductSubcategoryReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ProductSubcategoryDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IProductSubcategoryRepository
  : IRepository<ProductSubcategory, int, ProductSubcategoryReadModel, ProductSubcategoryCreateModel,
    ProductSubcategoryUpdateModel>
{
}
