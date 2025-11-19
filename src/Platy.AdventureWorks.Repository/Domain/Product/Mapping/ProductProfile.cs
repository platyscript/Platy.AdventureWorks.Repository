using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Product" /> .
/// </summary>
public class ProductProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductProfile" /> class.
  /// </summary>
  public ProductProfile()
  {
    CreateMap<Product, ProductReadModel>();

    CreateMap<ProductCreateModel, Product>();

    CreateMap<Product, ProductCreateModel>();

    CreateMap<Product, ProductUpdateModel>();

    CreateMap<ProductUpdateModel, Product>();

    CreateMap<ProductReadModel, ProductUpdateModel>();
  }
}
