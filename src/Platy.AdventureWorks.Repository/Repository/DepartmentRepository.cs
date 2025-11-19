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
///   Repository class representing data for table 'Department'.
/// </summary>
[RegisterScoped]
public class DepartmentRepository
  : EntityRepository<Department, short, DepartmentReadModel, DepartmentCreateModel, DepartmentUpdateModel>,
    IDepartmentRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="DepartmentRepository" /> class.
  /// </summary>
  public DepartmentRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<DepartmentRepository> logger,
    IValidator<DepartmentCreateModel> createValidator,
    IValidator<DepartmentUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="DepartmentReadModel" />.
  /// </summary>
  public async Task<Result<DepartmentReadModel>> GetAsync(short id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<Department, short>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="DepartmentReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<DepartmentReadModel>>> ListAsync(
    Expression<Func<Department, bool>>? predicate,
    CancellationToken cancellationToken)
  {
    return await QueryModel<Department, short>(predicate, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="Department" />.
  /// </summary>
  public async Task<Result<DepartmentReadModel>> CreateAsync(
    DepartmentCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new DepartmentCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="Department" />.
  /// </summary>
  public async Task<Result<DepartmentReadModel>> UpdateAsync(
    short id,
    DepartmentUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new DepartmentUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="Department" />.
  /// </summary>
  public virtual async Task<Result<DepartmentReadModel>> DeleteAsync(
    short id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new DepartmentDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IDepartmentRepository
  : IRepository<Department, short, DepartmentReadModel, DepartmentCreateModel, DepartmentUpdateModel>
{
}
