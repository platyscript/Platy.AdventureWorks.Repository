using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;
using Platy.Shared;
using FluentValidation;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using MediatR;


namespace Platy.AdventureWorks.Repository;

/// <summary>
/// Repository class representing data for table 'ProductReview'.
/// </summary>
[RegisterScoped]
public class ProductReviewRepository
    : EntityRepository<ProductReview,int, ProductReviewReadModel, ProductReviewCreateModel, ProductReviewUpdateModel>, IProductReviewRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReviewRepository"/> class.
    /// </summary>
    public ProductReviewRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductReviewRepository> logger,
        IValidator<ProductReviewCreateModel> createValidator,
        IValidator<ProductReviewUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductReviewReadModel" />.
    /// </summary>
    public async Task<Result<ProductReviewReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductReview, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductReviewReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductReviewReadModel>>> ListAsync(
       Expression<Func<ProductReview, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<ProductReview,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductReview" />.
    /// </summary>
     public async Task<Result<ProductReviewReadModel>> CreateAsync(
       ProductReviewCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new ProductReviewCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductReview" />.
    /// </summary>
     public async Task<Result<ProductReviewReadModel>> UpdateAsync(
       int id,
       ProductReviewUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new ProductReviewUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductReview" />.
    /// </summary>
      public virtual async Task<Result<ProductReviewReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new ProductReviewDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IProductReviewRepository
    : IRepository<ProductReview,int, ProductReviewReadModel, ProductReviewCreateModel, ProductReviewUpdateModel>
{
}

