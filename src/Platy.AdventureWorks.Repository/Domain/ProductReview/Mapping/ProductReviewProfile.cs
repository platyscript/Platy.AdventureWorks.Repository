using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductReview"/> .
/// </summary>
public partial class ProductReviewProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReviewProfile"/> class.
    /// </summary>
    public ProductReviewProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductReview, Platy.AdventureWorks.Repository.Domain.Models.ProductReviewReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductReviewCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductReview>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductReview, Platy.AdventureWorks.Repository.Domain.Models.ProductReviewCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductReview, Platy.AdventureWorks.Repository.Domain.Models.ProductReviewUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductReviewUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductReview>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductReviewReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductReviewUpdateModel>();

    }

}
