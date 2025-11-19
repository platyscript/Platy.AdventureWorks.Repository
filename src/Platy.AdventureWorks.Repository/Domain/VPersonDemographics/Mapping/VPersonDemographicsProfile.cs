using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VPersonDemographics" /> .
/// </summary>
public class VPersonDemographicsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VPersonDemographicsProfile" /> class.
  /// </summary>
  public VPersonDemographicsProfile()
  {
    CreateMap<VPersonDemographics, VPersonDemographicsReadModel>();

    CreateMap<VPersonDemographicsCreateModel, VPersonDemographics>();

    CreateMap<VPersonDemographics, VPersonDemographicsCreateModel>();

    CreateMap<VPersonDemographics, VPersonDemographicsUpdateModel>();

    CreateMap<VPersonDemographicsUpdateModel, VPersonDemographics>();

    CreateMap<VPersonDemographicsReadModel, VPersonDemographicsUpdateModel>();
  }
}
