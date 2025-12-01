using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidateEmployment"/> .
/// </summary>
public partial class VJobCandidateEmploymentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEmploymentProfile"/> class.
    /// </summary>
    public VJobCandidateEmploymentProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentReadModel, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentUpdateModel>();

    }

}
