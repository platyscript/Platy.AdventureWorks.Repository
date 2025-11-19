using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductListPriceHistory" /> .
/// </summary>
public class ProductListPriceHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductListPriceHistoryProfile" /> class.
  /// </summary>
  public ProductListPriceHistoryProfile()
  {
    CreateMap<ProductListPriceHistory, ProductListPriceHistoryReadModel>();

    CreateMap<ProductListPriceHistoryCreateModel, ProductListPriceHistory>();

    CreateMap<ProductListPriceHistory, ProductListPriceHistoryCreateModel>();

    CreateMap<ProductListPriceHistory, ProductListPriceHistoryUpdateModel>();

    CreateMap<ProductListPriceHistoryUpdateModel, ProductListPriceHistory>();

    CreateMap<ProductListPriceHistoryReadModel, ProductListPriceHistoryUpdateModel>();
  }
}
