using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductSubcategory"/> .
/// </summary>
public partial class ProductSubcategoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductSubcategoryProfile"/> class.
    /// </summary>
    public ProductSubcategoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory, Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory, Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory, Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductSubcategory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductSubcategoryUpdateModel>();

    }

}
