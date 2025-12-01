using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidate"/> .
/// </summary>
public partial class VJobCandidateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateProfile"/> class.
    /// </summary>
    public VJobCandidateProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VJobCandidate>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateReadModel, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateUpdateModel>();

    }

}
