using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductProductPhoto"/> .
/// </summary>
public partial class ProductProductPhotoProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProductPhotoProfile"/> class.
    /// </summary>
    public ProductProductPhotoProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto, Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto, Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto, Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductProductPhoto>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductProductPhotoUpdateModel>();

    }

}
