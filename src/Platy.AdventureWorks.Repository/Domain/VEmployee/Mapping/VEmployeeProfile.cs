using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployee"/> .
/// </summary>
public partial class VEmployeeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeProfile"/> class.
    /// </summary>
    public VEmployeeProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployee, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VEmployee>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployee, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VEmployee, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VEmployee>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VEmployeeReadModel, Platy.AdventureWorks.Repository.Domain.Models.VEmployeeUpdateModel>();

    }

}
