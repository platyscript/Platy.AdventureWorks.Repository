using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ShoppingCartItem" /> .
/// </summary>
public class ShoppingCartItemProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShoppingCartItemProfile" /> class.
  /// </summary>
  public ShoppingCartItemProfile()
  {
    CreateMap<ShoppingCartItem, ShoppingCartItemReadModel>();

    CreateMap<ShoppingCartItemCreateModel, ShoppingCartItem>();

    CreateMap<ShoppingCartItem, ShoppingCartItemCreateModel>();

    CreateMap<ShoppingCartItem, ShoppingCartItemUpdateModel>();

    CreateMap<ShoppingCartItemUpdateModel, ShoppingCartItem>();

    CreateMap<ShoppingCartItemReadModel, ShoppingCartItemUpdateModel>();
  }
}
