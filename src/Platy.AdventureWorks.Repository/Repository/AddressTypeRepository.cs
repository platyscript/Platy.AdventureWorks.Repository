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
///   Repository class representing data for table 'AddressType'.
/// </summary>
[RegisterScoped]
public class AddressTypeRepository
  : EntityRepository<AddressType, int, AddressTypeReadModel, AddressTypeCreateModel, AddressTypeUpdateModel>,
    IAddressTypeRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="AddressTypeRepository" /> class.
  /// </summary>
  public AddressTypeRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<AddressTypeRepository> logger,
    IValidator<AddressTypeCreateModel> createValidator,
    IValidator<AddressTypeUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="AddressTypeReadModel" />.
  /// </summary>
  public async Task<Result<AddressTypeReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<AddressType, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="AddressTypeReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<AddressTypeReadModel>>> ListAsync(
    Expression<Func<AddressType, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<AddressType, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="AddressType" />.
  /// </summary>
  public async Task<Result<AddressTypeReadModel>> CreateAsync(
    AddressTypeCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new AddressTypeCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="AddressType" />.
  /// </summary>
  public async Task<Result<AddressTypeReadModel>> UpdateAsync(
    int id,
    AddressTypeUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new AddressTypeUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="AddressType" />.
  /// </summary>
  public virtual async Task<Result<AddressTypeReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new AddressTypeDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IAddressTypeRepository
  : IRepository<AddressType, int, AddressTypeReadModel, AddressTypeCreateModel, AddressTypeUpdateModel>
{
}
