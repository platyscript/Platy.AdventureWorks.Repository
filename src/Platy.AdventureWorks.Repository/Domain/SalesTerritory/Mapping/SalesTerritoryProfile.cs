using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesTerritory" /> .
/// </summary>
public class SalesTerritoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTerritoryProfile" /> class.
  /// </summary>
  public SalesTerritoryProfile()
  {
    CreateMap<SalesTerritory, SalesTerritoryReadModel>();

    CreateMap<SalesTerritoryCreateModel, SalesTerritory>();

    CreateMap<SalesTerritory, SalesTerritoryCreateModel>();

    CreateMap<SalesTerritory, SalesTerritoryUpdateModel>();

    CreateMap<SalesTerritoryUpdateModel, SalesTerritory>();

    CreateMap<SalesTerritoryReadModel, SalesTerritoryUpdateModel>();
  }
}
