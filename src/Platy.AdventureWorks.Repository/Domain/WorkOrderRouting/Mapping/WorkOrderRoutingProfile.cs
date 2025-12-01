using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="WorkOrderRouting"/> .
/// </summary>
public partial class WorkOrderRoutingProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderRoutingProfile"/> class.
    /// </summary>
    public WorkOrderRoutingProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingCreateModel, Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.WorkOrderRouting>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingReadModel, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderRoutingUpdateModel>();

    }

}
