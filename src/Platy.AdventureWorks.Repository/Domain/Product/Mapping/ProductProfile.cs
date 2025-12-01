using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Product"/> .
/// </summary>
public partial class ProductProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProfile"/> class.
    /// </summary>
    public ProductProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Product, Platy.AdventureWorks.Repository.Domain.Models.ProductReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Product>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Product, Platy.AdventureWorks.Repository.Domain.Models.ProductCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Product, Platy.AdventureWorks.Repository.Domain.Models.ProductUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Product>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductUpdateModel>();

    }

}
