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
/// Repository class representing data for table 'WorkOrder'.
/// </summary>
[RegisterScoped]
public class WorkOrderRepository
    : EntityRepository<WorkOrder,int, WorkOrderReadModel, WorkOrderCreateModel, WorkOrderUpdateModel>, IWorkOrderRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderRepository"/> class.
    /// </summary>
    public WorkOrderRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<WorkOrderRepository> logger,
        IValidator<WorkOrderCreateModel> createValidator,
        IValidator<WorkOrderUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="WorkOrderReadModel" />.
    /// </summary>
    public async Task<Result<WorkOrderReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<WorkOrder, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="WorkOrderReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<WorkOrderReadModel>>> ListAsync(
       Expression<Func<WorkOrder, bool>>? predicate,
       CancellationToken cancellationToken) =>
       await QueryModel<WorkOrder,int>(predicate, cancellationToken);

    /// <summary>
    /// Creates an <see cref="WorkOrder" />.
    /// </summary>
     public async Task<Result<WorkOrderReadModel>> CreateAsync(
       WorkOrderCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel(createModel,
         new WorkOrderCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="WorkOrder" />.
    /// </summary>
     public async Task<Result<WorkOrderReadModel>> UpdateAsync(
       int id,
       WorkOrderUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel(id,
         updateModel,
         new WorkOrderUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="WorkOrder" />.
    /// </summary>
      public virtual async Task<Result<WorkOrderReadModel>> DeleteAsync(
       int id,
       CancellationToken cancellationToken) =>
       await DeleteModel(id,
         new WorkOrderDeletedEvent(),
         cancellationToken);

    #endregion
}

public interface IWorkOrderRepository
    : IRepository<WorkOrder,int, WorkOrderReadModel, WorkOrderCreateModel, WorkOrderUpdateModel>
{
}

