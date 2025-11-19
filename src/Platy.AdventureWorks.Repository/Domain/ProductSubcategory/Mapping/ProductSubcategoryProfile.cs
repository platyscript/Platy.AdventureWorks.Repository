using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductSubcategory" /> .
/// </summary>
public class ProductSubcategoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductSubcategoryProfile" /> class.
  /// </summary>
  public ProductSubcategoryProfile()
  {
    CreateMap<ProductSubcategory, ProductSubcategoryReadModel>();

    CreateMap<ProductSubcategoryCreateModel, ProductSubcategory>();

    CreateMap<ProductSubcategory, ProductSubcategoryCreateModel>();

    CreateMap<ProductSubcategory, ProductSubcategoryUpdateModel>();

    CreateMap<ProductSubcategoryUpdateModel, ProductSubcategory>();

    CreateMap<ProductSubcategoryReadModel, ProductSubcategoryUpdateModel>();
  }
}
