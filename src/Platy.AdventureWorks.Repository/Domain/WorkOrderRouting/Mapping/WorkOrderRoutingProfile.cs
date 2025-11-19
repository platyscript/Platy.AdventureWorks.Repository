using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="WorkOrderRouting" /> .
/// </summary>
public class WorkOrderRoutingProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="WorkOrderRoutingProfile" /> class.
  /// </summary>
  public WorkOrderRoutingProfile()
  {
    CreateMap<WorkOrderRouting, WorkOrderRoutingReadModel>();

    CreateMap<WorkOrderRoutingCreateModel, WorkOrderRouting>();

    CreateMap<WorkOrderRouting, WorkOrderRoutingCreateModel>();

    CreateMap<WorkOrderRouting, WorkOrderRoutingUpdateModel>();

    CreateMap<WorkOrderRoutingUpdateModel, WorkOrderRouting>();

    CreateMap<WorkOrderRoutingReadModel, WorkOrderRoutingUpdateModel>();
  }
}
