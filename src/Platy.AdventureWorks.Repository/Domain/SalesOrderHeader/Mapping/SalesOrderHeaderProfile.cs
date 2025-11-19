using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesOrderHeader" /> .
/// </summary>
public class SalesOrderHeaderProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeaderProfile" /> class.
  /// </summary>
  public SalesOrderHeaderProfile()
  {
    CreateMap<SalesOrderHeader, SalesOrderHeaderReadModel>();

    CreateMap<SalesOrderHeaderCreateModel, SalesOrderHeader>();

    CreateMap<SalesOrderHeader, SalesOrderHeaderCreateModel>();

    CreateMap<SalesOrderHeader, SalesOrderHeaderUpdateModel>();

    CreateMap<SalesOrderHeaderUpdateModel, SalesOrderHeader>();

    CreateMap<SalesOrderHeaderReadModel, SalesOrderHeaderUpdateModel>();
  }
}
