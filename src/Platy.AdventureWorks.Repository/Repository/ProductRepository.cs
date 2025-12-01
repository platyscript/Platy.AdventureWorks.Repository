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
/// Repository class representing data for table 'Product'.
/// </summary>
[RegisterScoped]
public class ProductRepository
    : EntityRepository<Product,int, ProductReadModel, ProductCreateModel, ProductUpdateModel>, IProductRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRepository"/> class.
    /// </summary>
    public ProductRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductRepository> logger,
        IValidator<ProductCreateModel> createValidator,
        IValidator<ProductUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductReadModel" />.
    /// </summary>
    public async Task<Result<ProductReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<Product, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductReadModel>>> ListAsync(
       Expression<Func<Product, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<Product,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Product" />.
    /// </summary>
     public async Task<Result<ProductReadModel>> CreateAsync(
       ProductCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new ProductCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Product" />.
    /// </summary>
     public async Task<Result<ProductReadModel>> UpdateAsync(
       int id,
       ProductUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new ProductUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Product" />.
    /// </summary>
      public virtual async Task<Result<ProductReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new ProductDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IProductRepository
    : IRepository<Product,int, ProductReadModel, ProductCreateModel, ProductUpdateModel>
{
}

