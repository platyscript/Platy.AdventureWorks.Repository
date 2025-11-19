using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductCostHistory" /> .
/// </summary>
public class ProductCostHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductCostHistoryProfile" /> class.
  /// </summary>
  public ProductCostHistoryProfile()
  {
    CreateMap<ProductCostHistory, ProductCostHistoryReadModel>();

    CreateMap<ProductCostHistoryCreateModel, ProductCostHistory>();

    CreateMap<ProductCostHistory, ProductCostHistoryCreateModel>();

    CreateMap<ProductCostHistory, ProductCostHistoryUpdateModel>();

    CreateMap<ProductCostHistoryUpdateModel, ProductCostHistory>();

    CreateMap<ProductCostHistoryReadModel, ProductCostHistoryUpdateModel>();
  }
}
