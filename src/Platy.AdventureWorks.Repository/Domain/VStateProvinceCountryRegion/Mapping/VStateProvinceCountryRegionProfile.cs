using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VStateProvinceCountryRegion" /> .
/// </summary>
public class VStateProvinceCountryRegionProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStateProvinceCountryRegionProfile" /> class.
  /// </summary>
  public VStateProvinceCountryRegionProfile()
  {
    CreateMap<VStateProvinceCountryRegion, VStateProvinceCountryRegionReadModel>();

    CreateMap<VStateProvinceCountryRegionCreateModel, VStateProvinceCountryRegion>();

    CreateMap<VStateProvinceCountryRegion, VStateProvinceCountryRegionCreateModel>();

    CreateMap<VStateProvinceCountryRegion, VStateProvinceCountryRegionUpdateModel>();

    CreateMap<VStateProvinceCountryRegionUpdateModel, VStateProvinceCountryRegion>();

    CreateMap<VStateProvinceCountryRegionReadModel, VStateProvinceCountryRegionUpdateModel>();
  }
}
