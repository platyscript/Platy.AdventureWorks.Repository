using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModelProductDescriptionCulture"/> .
/// </summary>
public partial class ProductModelProductDescriptionCultureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProductDescriptionCultureProfile"/> class.
    /// </summary>
    public ProductModelProductDescriptionCultureProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture, Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture, Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture, Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureUpdateModel>();

    }

}
