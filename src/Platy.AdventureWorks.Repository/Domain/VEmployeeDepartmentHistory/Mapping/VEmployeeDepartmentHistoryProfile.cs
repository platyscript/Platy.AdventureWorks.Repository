using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployeeDepartmentHistory"/> .
/// </summary>
public partial class VEmployeeDepartmentHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentHistoryProfile"/> class.
    /// </summary>
    public VEmployeeDepartmentHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryUpdateModel>();

    }

}
