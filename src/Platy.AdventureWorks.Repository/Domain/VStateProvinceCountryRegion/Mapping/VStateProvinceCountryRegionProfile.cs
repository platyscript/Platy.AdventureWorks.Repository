using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStateProvinceCountryRegion"/> .
/// </summary>
public partial class VStateProvinceCountryRegionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStateProvinceCountryRegionProfile"/> class.
    /// </summary>
    public VStateProvinceCountryRegionProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion, Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion, Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion, Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionReadModel, Platy.AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionUpdateModel>();

    }

}
