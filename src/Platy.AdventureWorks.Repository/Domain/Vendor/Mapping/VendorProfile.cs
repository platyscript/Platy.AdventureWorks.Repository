using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Vendor"/> .
/// </summary>
public partial class VendorProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VendorProfile"/> class.
    /// </summary>
    public VendorProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Vendor, Platy.AdventureWorks.Repository.Domain.Models.VendorReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VendorCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Vendor>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Vendor, Platy.AdventureWorks.Repository.Domain.Models.VendorCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Vendor, Platy.AdventureWorks.Repository.Domain.Models.VendorUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VendorUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Vendor>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VendorReadModel, Platy.AdventureWorks.Repository.Domain.Models.VendorUpdateModel>();

    }

}
