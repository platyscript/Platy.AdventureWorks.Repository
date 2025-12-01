using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductCategory"/> .
/// </summary>
public partial class ProductCategoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCategoryProfile"/> class.
    /// </summary>
    public ProductCategoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductCategory, Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductCategory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductCategory, Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductCategory, Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductCategory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductCategoryUpdateModel>();

    }

}
