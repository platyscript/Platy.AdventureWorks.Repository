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
///   Repository class representing data for table 'ProductPhoto'.
/// </summary>
[RegisterScoped]
public class ProductPhotoRepository
  : EntityRepository<ProductPhoto, int, ProductPhotoReadModel, ProductPhotoCreateModel, ProductPhotoUpdateModel>,
    IProductPhotoRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductPhotoRepository" /> class.
  /// </summary>
  public ProductPhotoRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ProductPhotoRepository> logger,
    IValidator<ProductPhotoCreateModel> createValidator,
    IValidator<ProductPhotoUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ProductPhotoReadModel" />.
  /// </summary>
  public async Task<Result<ProductPhotoReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ProductPhoto, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ProductPhotoReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ProductPhotoReadModel>>> ListAsync(
    Expression<Func<ProductPhoto, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<ProductPhoto, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ProductPhoto" />.
  /// </summary>
  public async Task<Result<ProductPhotoReadModel>> CreateAsync(
    ProductPhotoCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ProductPhotoCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ProductPhoto" />.
  /// </summary>
  public async Task<Result<ProductPhotoReadModel>> UpdateAsync(
    int id,
    ProductPhotoUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ProductPhotoUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ProductPhoto" />.
  /// </summary>
  public virtual async Task<Result<ProductPhotoReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ProductPhotoDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IProductPhotoRepository
  : IRepository<ProductPhoto, int, ProductPhotoReadModel, ProductPhotoCreateModel, ProductPhotoUpdateModel>
{
}
