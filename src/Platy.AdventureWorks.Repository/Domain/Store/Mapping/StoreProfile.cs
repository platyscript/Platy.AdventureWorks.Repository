using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Store"/> .
/// </summary>
public partial class StoreProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StoreProfile"/> class.
    /// </summary>
    public StoreProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Store, Platy.AdventureWorks.Repository.Domain.Models.StoreReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.StoreCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Store>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Store, Platy.AdventureWorks.Repository.Domain.Models.StoreCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Store, Platy.AdventureWorks.Repository.Domain.Models.StoreUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.StoreUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Store>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.StoreReadModel, Platy.AdventureWorks.Repository.Domain.Models.StoreUpdateModel>();

    }

}
