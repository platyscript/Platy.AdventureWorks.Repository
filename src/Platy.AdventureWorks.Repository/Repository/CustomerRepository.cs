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
///   Repository class representing data for table 'Customer'.
/// </summary>
[RegisterScoped]
public class CustomerRepository
  : EntityRepository<Customer, int, CustomerReadModel, CustomerCreateModel, CustomerUpdateModel>, ICustomerRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CustomerRepository" /> class.
  /// </summary>
  public CustomerRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<CustomerRepository> logger,
    IValidator<CustomerCreateModel> createValidator,
    IValidator<CustomerUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="CustomerReadModel" />.
  /// </summary>
  public async Task<Result<CustomerReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<Customer, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="CustomerReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<CustomerReadModel>>> ListAsync(
    Expression<Func<Customer, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<Customer, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="Customer" />.
  /// </summary>
  public async Task<Result<CustomerReadModel>> CreateAsync(
    CustomerCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new CustomerCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="Customer" />.
  /// </summary>
  public async Task<Result<CustomerReadModel>> UpdateAsync(
    int id,
    CustomerUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new CustomerUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="Customer" />.
  /// </summary>
  public virtual async Task<Result<CustomerReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new CustomerDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface ICustomerRepository
  : IRepository<Customer, int, CustomerReadModel, CustomerCreateModel, CustomerUpdateModel>
{
}
