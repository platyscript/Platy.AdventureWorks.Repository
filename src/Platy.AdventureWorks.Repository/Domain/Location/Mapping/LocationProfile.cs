using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Location"/> .
/// </summary>
public partial class LocationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationProfile"/> class.
    /// </summary>
    public LocationProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Location, Platy.AdventureWorks.Repository.Domain.Models.LocationReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.LocationCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Location>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Location, Platy.AdventureWorks.Repository.Domain.Models.LocationCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Location, Platy.AdventureWorks.Repository.Domain.Models.LocationUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.LocationUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Location>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.LocationReadModel, Platy.AdventureWorks.Repository.Domain.Models.LocationUpdateModel>();

    }

}
