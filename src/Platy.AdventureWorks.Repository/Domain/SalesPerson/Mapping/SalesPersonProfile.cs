using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesPerson" /> .
/// </summary>
public class SalesPersonProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesPersonProfile" /> class.
  /// </summary>
  public SalesPersonProfile()
  {
    CreateMap<SalesPerson, SalesPersonReadModel>();

    CreateMap<SalesPersonCreateModel, SalesPerson>();

    CreateMap<SalesPerson, SalesPersonCreateModel>();

    CreateMap<SalesPerson, SalesPersonUpdateModel>();

    CreateMap<SalesPersonUpdateModel, SalesPerson>();

    CreateMap<SalesPersonReadModel, SalesPersonUpdateModel>();
  }
}
