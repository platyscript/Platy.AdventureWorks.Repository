using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="StateProvince" /> .
/// </summary>
public class StateProvinceProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="StateProvinceProfile" /> class.
  /// </summary>
  public StateProvinceProfile()
  {
    CreateMap<StateProvince, StateProvinceReadModel>();

    CreateMap<StateProvinceCreateModel, StateProvince>();

    CreateMap<StateProvince, StateProvinceCreateModel>();

    CreateMap<StateProvince, StateProvinceUpdateModel>();

    CreateMap<StateProvinceUpdateModel, StateProvince>();

    CreateMap<StateProvinceReadModel, StateProvinceUpdateModel>();
  }
}
