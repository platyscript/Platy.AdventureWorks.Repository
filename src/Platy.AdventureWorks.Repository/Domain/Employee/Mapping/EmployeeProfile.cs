using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Employee"/> .
/// </summary>
public partial class EmployeeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeProfile"/> class.
    /// </summary>
    public EmployeeProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Employee, Platy.AdventureWorks.Repository.Domain.Models.EmployeeReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeeCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Employee>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Employee, Platy.AdventureWorks.Repository.Domain.Models.EmployeeCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Employee, Platy.AdventureWorks.Repository.Domain.Models.EmployeeUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeeUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Employee>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeeReadModel, Platy.AdventureWorks.Repository.Domain.Models.EmployeeUpdateModel>();

    }

}
