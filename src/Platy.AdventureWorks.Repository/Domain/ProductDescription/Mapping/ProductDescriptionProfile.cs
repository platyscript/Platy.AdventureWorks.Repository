using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductDescription"/> .
/// </summary>
public partial class ProductDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDescriptionProfile"/> class.
    /// </summary>
    public ProductDescriptionProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductDescription, Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductDescription>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductDescription, Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductDescription, Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductDescription>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductDescriptionUpdateModel>();

    }

}
