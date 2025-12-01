using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="WorkOrder"/> .
/// </summary>
public partial class WorkOrderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderProfile"/> class.
    /// </summary>
    public WorkOrderProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.WorkOrder, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.WorkOrderCreateModel, Platy.AdventureWorks.Repository.Data.Entities.WorkOrder>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.WorkOrder, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.WorkOrder, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.WorkOrderUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.WorkOrder>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.WorkOrderReadModel, Platy.AdventureWorks.Repository.Domain.Models.WorkOrderUpdateModel>();

    }

}
