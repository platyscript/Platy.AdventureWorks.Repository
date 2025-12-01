using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Department"/> .
/// </summary>
public partial class DepartmentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepartmentProfile"/> class.
    /// </summary>
    public DepartmentProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Department, Platy.AdventureWorks.Repository.Domain.Models.DepartmentReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.DepartmentCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Department>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Department, Platy.AdventureWorks.Repository.Domain.Models.DepartmentCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Department, Platy.AdventureWorks.Repository.Domain.Models.DepartmentUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.DepartmentUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Department>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.DepartmentReadModel, Platy.AdventureWorks.Repository.Domain.Models.DepartmentUpdateModel>();

    }

}
