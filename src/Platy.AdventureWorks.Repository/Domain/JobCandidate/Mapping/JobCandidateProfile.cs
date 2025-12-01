using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="JobCandidate"/> .
/// </summary>
public partial class JobCandidateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobCandidateProfile"/> class.
    /// </summary>
    public JobCandidateProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.JobCandidate, Platy.AdventureWorks.Repository.Domain.Models.JobCandidateReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.JobCandidateCreateModel, Platy.AdventureWorks.Repository.Data.Entities.JobCandidate>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.JobCandidate, Platy.AdventureWorks.Repository.Domain.Models.JobCandidateCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.JobCandidate, Platy.AdventureWorks.Repository.Domain.Models.JobCandidateUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.JobCandidateUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.JobCandidate>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.JobCandidateReadModel, Platy.AdventureWorks.Repository.Domain.Models.JobCandidateUpdateModel>();

    }

}
