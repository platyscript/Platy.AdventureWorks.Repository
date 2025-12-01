using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithAddresses"/> .
/// </summary>
public partial class VStoreWithAddressesProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithAddressesProfile"/> class.
    /// </summary>
    public VStoreWithAddressesProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VStoreWithAddresses>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesReadModel, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithAddressesUpdateModel>();

    }

}
