using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VStoreWithDemographics" /> .
/// </summary>
public class VStoreWithDemographicsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStoreWithDemographicsProfile" /> class.
  /// </summary>
  public VStoreWithDemographicsProfile()
  {
    CreateMap<VStoreWithDemographics, VStoreWithDemographicsReadModel>();

    CreateMap<VStoreWithDemographicsCreateModel, VStoreWithDemographics>();

    CreateMap<VStoreWithDemographics, VStoreWithDemographicsCreateModel>();

    CreateMap<VStoreWithDemographics, VStoreWithDemographicsUpdateModel>();

    CreateMap<VStoreWithDemographicsUpdateModel, VStoreWithDemographics>();

    CreateMap<VStoreWithDemographicsReadModel, VStoreWithDemographicsUpdateModel>();
  }
}
