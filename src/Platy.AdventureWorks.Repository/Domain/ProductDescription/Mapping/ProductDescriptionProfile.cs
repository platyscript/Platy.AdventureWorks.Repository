using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductDescription" /> .
/// </summary>
public class ProductDescriptionProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductDescriptionProfile" /> class.
  /// </summary>
  public ProductDescriptionProfile()
  {
    CreateMap<ProductDescription, ProductDescriptionReadModel>();

    CreateMap<ProductDescriptionCreateModel, ProductDescription>();

    CreateMap<ProductDescription, ProductDescriptionCreateModel>();

    CreateMap<ProductDescription, ProductDescriptionUpdateModel>();

    CreateMap<ProductDescriptionUpdateModel, ProductDescription>();

    CreateMap<ProductDescriptionReadModel, ProductDescriptionUpdateModel>();
  }
}
