using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesTerritoryHistory" /> .
/// </summary>
public class SalesTerritoryHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTerritoryHistoryProfile" /> class.
  /// </summary>
  public SalesTerritoryHistoryProfile()
  {
    CreateMap<SalesTerritoryHistory, SalesTerritoryHistoryReadModel>();

    CreateMap<SalesTerritoryHistoryCreateModel, SalesTerritoryHistory>();

    CreateMap<SalesTerritoryHistory, SalesTerritoryHistoryCreateModel>();

    CreateMap<SalesTerritoryHistory, SalesTerritoryHistoryUpdateModel>();

    CreateMap<SalesTerritoryHistoryUpdateModel, SalesTerritoryHistory>();

    CreateMap<SalesTerritoryHistoryReadModel, SalesTerritoryHistoryUpdateModel>();
  }
}
