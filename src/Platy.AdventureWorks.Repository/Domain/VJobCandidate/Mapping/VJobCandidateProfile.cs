using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VJobCandidate" /> .
/// </summary>
public class VJobCandidateProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateProfile" /> class.
  /// </summary>
  public VJobCandidateProfile()
  {
    CreateMap<VJobCandidate, VJobCandidateReadModel>();

    CreateMap<VJobCandidateCreateModel, VJobCandidate>();

    CreateMap<VJobCandidate, VJobCandidateCreateModel>();

    CreateMap<VJobCandidate, VJobCandidateUpdateModel>();

    CreateMap<VJobCandidateUpdateModel, VJobCandidate>();

    CreateMap<VJobCandidateReadModel, VJobCandidateUpdateModel>();
  }
}
