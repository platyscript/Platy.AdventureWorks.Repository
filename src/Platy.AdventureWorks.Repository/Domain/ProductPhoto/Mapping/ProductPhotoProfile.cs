using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductPhoto"/> .
/// </summary>
public partial class ProductPhotoProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductPhotoProfile"/> class.
    /// </summary>
    public ProductPhotoProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto, Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto, Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto, Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductPhoto>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductPhotoUpdateModel>();

    }

}
