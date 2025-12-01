using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmployeeDepartmentHistory"/> .
/// </summary>
public partial class EmployeeDepartmentHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeDepartmentHistoryProfile"/> class.
    /// </summary>
    public EmployeeDepartmentHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryUpdateModel>();

    }

}
