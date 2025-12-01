using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductInventory"/> .
/// </summary>
public partial class ProductInventoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductInventoryProfile"/> class.
    /// </summary>
    public ProductInventoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductInventory, Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductInventory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductInventory, Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductInventory, Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductInventory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductInventoryUpdateModel>();

    }

}
