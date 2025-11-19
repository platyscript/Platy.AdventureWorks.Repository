using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VJobCandidateEducation" /> .
/// </summary>
public class VJobCandidateEducationProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateEducationProfile" /> class.
  /// </summary>
  public VJobCandidateEducationProfile()
  {
    CreateMap<VJobCandidateEducation, VJobCandidateEducationReadModel>();

    CreateMap<VJobCandidateEducationCreateModel, VJobCandidateEducation>();

    CreateMap<VJobCandidateEducation, VJobCandidateEducationCreateModel>();

    CreateMap<VJobCandidateEducation, VJobCandidateEducationUpdateModel>();

    CreateMap<VJobCandidateEducationUpdateModel, VJobCandidateEducation>();

    CreateMap<VJobCandidateEducationReadModel, VJobCandidateEducationUpdateModel>();
  }
}
