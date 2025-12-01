using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CountryRegion"/> .
/// </summary>
public partial class CountryRegionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionProfile"/> class.
    /// </summary>
    public CountryRegionProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CountryRegion, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCreateModel, Platy.AdventureWorks.Repository.Data.Entities.CountryRegion>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CountryRegion, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CountryRegion, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CountryRegionUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.CountryRegion>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CountryRegionReadModel, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionUpdateModel>();

    }

}
