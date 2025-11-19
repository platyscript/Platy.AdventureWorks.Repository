using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductVendor" /> .
/// </summary>
public class ProductVendorProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductVendorProfile" /> class.
  /// </summary>
  public ProductVendorProfile()
  {
    CreateMap<ProductVendor, ProductVendorReadModel>();

    CreateMap<ProductVendorCreateModel, ProductVendor>();

    CreateMap<ProductVendor, ProductVendorCreateModel>();

    CreateMap<ProductVendor, ProductVendorUpdateModel>();

    CreateMap<ProductVendorUpdateModel, ProductVendor>();

    CreateMap<ProductVendorReadModel, ProductVendorUpdateModel>();
  }
}
