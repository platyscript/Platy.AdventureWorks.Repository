using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="StateProvince"/> .
/// </summary>
public partial class StateProvinceProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StateProvinceProfile"/> class.
    /// </summary>
    public StateProvinceProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.StateProvince, Platy.AdventureWorks.Repository.Domain.Models.StateProvinceReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.StateProvinceCreateModel, Platy.AdventureWorks.Repository.Data.Entities.StateProvince>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.StateProvince, Platy.AdventureWorks.Repository.Domain.Models.StateProvinceCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.StateProvince, Platy.AdventureWorks.Repository.Domain.Models.StateProvinceUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.StateProvinceUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.StateProvince>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.StateProvinceReadModel, Platy.AdventureWorks.Repository.Domain.Models.StateProvinceUpdateModel>();

    }

}
