using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VVendorWithAddresses"/> .
/// </summary>
public partial class VVendorWithAddressesProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VVendorWithAddressesProfile"/> class.
    /// </summary>
    public VVendorWithAddressesProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesReadModel, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithAddressesUpdateModel>();

    }

}
