using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModel"/> .
/// </summary>
public partial class ProductModelProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProfile"/> class.
    /// </summary>
    public ProductModelProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModel, Platy.AdventureWorks.Repository.Domain.Models.ProductModelReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModel, Platy.AdventureWorks.Repository.Domain.Models.ProductModelCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModel, Platy.AdventureWorks.Repository.Domain.Models.ProductModelUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductModelUpdateModel>();

    }

}
