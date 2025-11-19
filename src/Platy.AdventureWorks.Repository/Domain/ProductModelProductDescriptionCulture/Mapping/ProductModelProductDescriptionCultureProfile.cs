using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductModelProductDescriptionCulture" /> .
/// </summary>
public class ProductModelProductDescriptionCultureProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductModelProductDescriptionCultureProfile" /> class.
  /// </summary>
  public ProductModelProductDescriptionCultureProfile()
  {
    CreateMap<ProductModelProductDescriptionCulture, ProductModelProductDescriptionCultureReadModel>();

    CreateMap<ProductModelProductDescriptionCultureCreateModel, ProductModelProductDescriptionCulture>();

    CreateMap<ProductModelProductDescriptionCulture, ProductModelProductDescriptionCultureCreateModel>();

    CreateMap<ProductModelProductDescriptionCulture, ProductModelProductDescriptionCultureUpdateModel>();

    CreateMap<ProductModelProductDescriptionCultureUpdateModel, ProductModelProductDescriptionCulture>();

    CreateMap<ProductModelProductDescriptionCultureReadModel, ProductModelProductDescriptionCultureUpdateModel>();
  }
}
