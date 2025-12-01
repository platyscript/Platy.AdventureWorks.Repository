using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductVendor"/> .
/// </summary>
public partial class ProductVendorProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductVendorProfile"/> class.
    /// </summary>
    public ProductVendorProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductVendor, Platy.AdventureWorks.Repository.Domain.Models.ProductVendorReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductVendorCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductVendor>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductVendor, Platy.AdventureWorks.Repository.Domain.Models.ProductVendorCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductVendor, Platy.AdventureWorks.Repository.Domain.Models.ProductVendorUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductVendorUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductVendor>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductVendorReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductVendorUpdateModel>();

    }

}
