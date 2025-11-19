using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductReview" /> .
/// </summary>
public class ProductReviewProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductReviewProfile" /> class.
  /// </summary>
  public ProductReviewProfile()
  {
    CreateMap<ProductReview, ProductReviewReadModel>();

    CreateMap<ProductReviewCreateModel, ProductReview>();

    CreateMap<ProductReview, ProductReviewCreateModel>();

    CreateMap<ProductReview, ProductReviewUpdateModel>();

    CreateMap<ProductReviewUpdateModel, ProductReview>();

    CreateMap<ProductReviewReadModel, ProductReviewUpdateModel>();
  }
}
