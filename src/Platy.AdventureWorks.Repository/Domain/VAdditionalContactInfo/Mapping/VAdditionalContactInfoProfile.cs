using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VAdditionalContactInfo" /> .
/// </summary>
public class VAdditionalContactInfoProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VAdditionalContactInfoProfile" /> class.
  /// </summary>
  public VAdditionalContactInfoProfile()
  {
    CreateMap<VAdditionalContactInfo, VAdditionalContactInfoReadModel>();

    CreateMap<VAdditionalContactInfoCreateModel, VAdditionalContactInfo>();

    CreateMap<VAdditionalContactInfo, VAdditionalContactInfoCreateModel>();

    CreateMap<VAdditionalContactInfo, VAdditionalContactInfoUpdateModel>();

    CreateMap<VAdditionalContactInfoUpdateModel, VAdditionalContactInfo>();

    CreateMap<VAdditionalContactInfoReadModel, VAdditionalContactInfoUpdateModel>();
  }
}
