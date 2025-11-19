using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="JobCandidate" /> .
/// </summary>
public class JobCandidateProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="JobCandidateProfile" /> class.
  /// </summary>
  public JobCandidateProfile()
  {
    CreateMap<JobCandidate, JobCandidateReadModel>();

    CreateMap<JobCandidateCreateModel, JobCandidate>();

    CreateMap<JobCandidate, JobCandidateCreateModel>();

    CreateMap<JobCandidate, JobCandidateUpdateModel>();

    CreateMap<JobCandidateUpdateModel, JobCandidate>();

    CreateMap<JobCandidateReadModel, JobCandidateUpdateModel>();
  }
}
