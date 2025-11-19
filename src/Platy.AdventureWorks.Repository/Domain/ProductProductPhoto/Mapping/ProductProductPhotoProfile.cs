using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductProductPhoto" /> .
/// </summary>
public class ProductProductPhotoProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductProductPhotoProfile" /> class.
  /// </summary>
  public ProductProductPhotoProfile()
  {
    CreateMap<ProductProductPhoto, ProductProductPhotoReadModel>();

    CreateMap<ProductProductPhotoCreateModel, ProductProductPhoto>();

    CreateMap<ProductProductPhoto, ProductProductPhotoCreateModel>();

    CreateMap<ProductProductPhoto, ProductProductPhotoUpdateModel>();

    CreateMap<ProductProductPhotoUpdateModel, ProductProductPhoto>();

    CreateMap<ProductProductPhotoReadModel, ProductProductPhotoUpdateModel>();
  }
}
