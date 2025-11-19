using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductCategory" /> .
/// </summary>
public class ProductCategoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductCategoryProfile" /> class.
  /// </summary>
  public ProductCategoryProfile()
  {
    CreateMap<ProductCategory, ProductCategoryReadModel>();

    CreateMap<ProductCategoryCreateModel, ProductCategory>();

    CreateMap<ProductCategory, ProductCategoryCreateModel>();

    CreateMap<ProductCategory, ProductCategoryUpdateModel>();

    CreateMap<ProductCategoryUpdateModel, ProductCategory>();

    CreateMap<ProductCategoryReadModel, ProductCategoryUpdateModel>();
  }
}
