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
///   Repository class representing data for table 'PhoneNumberType'.
/// </summary>
[RegisterScoped]
public class PhoneNumberTypeRepository
  : EntityRepository<PhoneNumberType, int, PhoneNumberTypeReadModel, PhoneNumberTypeCreateModel,
    PhoneNumberTypeUpdateModel>, IPhoneNumberTypeRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PhoneNumberTypeRepository" /> class.
  /// </summary>
  public PhoneNumberTypeRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<PhoneNumberTypeRepository> logger,
    IValidator<PhoneNumberTypeCreateModel> createValidator,
    IValidator<PhoneNumberTypeUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="PhoneNumberTypeReadModel" />.
  /// </summary>
  public async Task<Result<PhoneNumberTypeReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<PhoneNumberType, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="PhoneNumberTypeReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<PhoneNumberTypeReadModel>>> ListAsync(
    Expression<Func<PhoneNumberType, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<PhoneNumberType, int>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="PhoneNumberType" />.
  /// </summary>
  public async Task<Result<PhoneNumberTypeReadModel>> CreateAsync(
    PhoneNumberTypeCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new PhoneNumberTypeCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="PhoneNumberType" />.
  /// </summary>
  public async Task<Result<PhoneNumberTypeReadModel>> UpdateAsync(
    int id,
    PhoneNumberTypeUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new PhoneNumberTypeUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="PhoneNumberType" />.
  /// </summary>
  public virtual async Task<Result<PhoneNumberTypeReadModel>> DeleteAsync(
    int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new PhoneNumberTypeDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IPhoneNumberTypeRepository
  : IRepository<PhoneNumberType, int, PhoneNumberTypeReadModel, PhoneNumberTypeCreateModel, PhoneNumberTypeUpdateModel>
{
}
