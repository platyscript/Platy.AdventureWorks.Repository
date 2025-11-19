using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="CountryRegion" /> .
/// </summary>
public class CountryRegionProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CountryRegionProfile" /> class.
  /// </summary>
  public CountryRegionProfile()
  {
    CreateMap<CountryRegion, CountryRegionReadModel>();

    CreateMap<CountryRegionCreateModel, CountryRegion>();

    CreateMap<CountryRegion, CountryRegionCreateModel>();

    CreateMap<CountryRegion, CountryRegionUpdateModel>();

    CreateMap<CountryRegionUpdateModel, CountryRegion>();

    CreateMap<CountryRegionReadModel, CountryRegionUpdateModel>();
  }
}
