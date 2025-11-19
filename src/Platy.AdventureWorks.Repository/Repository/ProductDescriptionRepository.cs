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
///   Repository class representing data for table 'ProductDescription'.
/// </summary>
[RegisterScoped]
public class ProductDescriptionRepository
  : EntityRepository<ProductDescription, int, ProductDescriptionReadModel, ProductDescriptionCreateModel,
    ProductDescriptionUpdateModel>, IProductDescriptionRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductDescriptionRepository" /> class.
  /// </summary>
  public ProductDescriptionRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ProductDescriptionRepository> logger,
    IValidator<ProductDescriptionCreateModel> createValidator,
    IValidator<ProductDescriptionUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ProductDescriptionReadModel" />.
  /// </summary>
  public async Task<Result<ProductDescriptionReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ProductDescription, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ProductDescriptionReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ProductDescriptionReadModel>>> ListAsync(
    Expression<Func<ProductDescription, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ProductDescription, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ProductDescription" />.
  /// </summary>
  public async Task<Result<ProductDescriptionReadModel>> CreateAsync(
    ProductDescriptionCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ProductDescriptionCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ProductDescription" />.
  /// </summary>
  public async Task<Result<ProductDescriptionReadModel>> UpdateAsync(
    int id,
    ProductDescriptionUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ProductDescriptionUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ProductDescription" />.
  /// </summary>
  public virtual async Task<Result<ProductDescriptionReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ProductDescriptionDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IProductDescriptionRepository
  : IRepository<ProductDescription, int, ProductDescriptionReadModel, ProductDescriptionCreateModel,
    ProductDescriptionUpdateModel>
{
}
