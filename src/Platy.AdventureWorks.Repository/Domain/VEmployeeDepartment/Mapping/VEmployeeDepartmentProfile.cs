using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployeeDepartment"/> .
/// </summary>
public partial class VEmployeeDepartmentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentProfile"/> class.
    /// </summary>
    public VEmployeeDepartmentProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartment>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentReadModel, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentUpdateModel>();

    }

}
