using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VJobCandidateEmployment" /> .
/// </summary>
public class VJobCandidateEmploymentProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateEmploymentProfile" /> class.
  /// </summary>
  public VJobCandidateEmploymentProfile()
  {
    CreateMap<VJobCandidateEmployment, VJobCandidateEmploymentReadModel>();

    CreateMap<VJobCandidateEmploymentCreateModel, VJobCandidateEmployment>();

    CreateMap<VJobCandidateEmployment, VJobCandidateEmploymentCreateModel>();

    CreateMap<VJobCandidateEmployment, VJobCandidateEmploymentUpdateModel>();

    CreateMap<VJobCandidateEmploymentUpdateModel, VJobCandidateEmployment>();

    CreateMap<VJobCandidateEmploymentReadModel, VJobCandidateEmploymentUpdateModel>();
  }
}
