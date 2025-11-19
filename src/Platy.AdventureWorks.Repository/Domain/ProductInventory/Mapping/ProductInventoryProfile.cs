using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductInventory" /> .
/// </summary>
public class ProductInventoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductInventoryProfile" /> class.
  /// </summary>
  public ProductInventoryProfile()
  {
    CreateMap<ProductInventory, ProductInventoryReadModel>();

    CreateMap<ProductInventoryCreateModel, ProductInventory>();

    CreateMap<ProductInventory, ProductInventoryCreateModel>();

    CreateMap<ProductInventory, ProductInventoryUpdateModel>();

    CreateMap<ProductInventoryUpdateModel, ProductInventory>();

    CreateMap<ProductInventoryReadModel, ProductInventoryUpdateModel>();
  }
}
