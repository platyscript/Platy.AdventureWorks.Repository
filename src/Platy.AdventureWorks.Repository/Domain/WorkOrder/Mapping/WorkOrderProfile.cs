using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="WorkOrder" /> .
/// </summary>
public class WorkOrderProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="WorkOrderProfile" /> class.
  /// </summary>
  public WorkOrderProfile()
  {
    CreateMap<WorkOrder, WorkOrderReadModel>();

    CreateMap<WorkOrderCreateModel, WorkOrder>();

    CreateMap<WorkOrder, WorkOrderCreateModel>();

    CreateMap<WorkOrder, WorkOrderUpdateModel>();

    CreateMap<WorkOrderUpdateModel, WorkOrder>();

    CreateMap<WorkOrderReadModel, WorkOrderUpdateModel>();
  }
}
