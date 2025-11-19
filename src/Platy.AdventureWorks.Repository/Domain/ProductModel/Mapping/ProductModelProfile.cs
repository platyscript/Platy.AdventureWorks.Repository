using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductModel" /> .
/// </summary>
public class ProductModelProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductModelProfile" /> class.
  /// </summary>
  public ProductModelProfile()
  {
    CreateMap<ProductModel, ProductModelReadModel>();

    CreateMap<ProductModelCreateModel, ProductModel>();

    CreateMap<ProductModel, ProductModelCreateModel>();

    CreateMap<ProductModel, ProductModelUpdateModel>();

    CreateMap<ProductModelUpdateModel, ProductModel>();

    CreateMap<ProductModelReadModel, ProductModelUpdateModel>();
  }
}
