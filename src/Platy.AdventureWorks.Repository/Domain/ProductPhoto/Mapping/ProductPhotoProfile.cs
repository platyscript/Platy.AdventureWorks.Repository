using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductPhoto" /> .
/// </summary>
public class ProductPhotoProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductPhotoProfile" /> class.
  /// </summary>
  public ProductPhotoProfile()
  {
    CreateMap<ProductPhoto, ProductPhotoReadModel>();

    CreateMap<ProductPhotoCreateModel, ProductPhoto>();

    CreateMap<ProductPhoto, ProductPhotoCreateModel>();

    CreateMap<ProductPhoto, ProductPhotoUpdateModel>();

    CreateMap<ProductPhotoUpdateModel, ProductPhoto>();

    CreateMap<ProductPhotoReadModel, ProductPhotoUpdateModel>();
  }
}
