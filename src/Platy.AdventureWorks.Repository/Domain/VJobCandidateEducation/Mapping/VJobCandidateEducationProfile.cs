using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidateEducation"/> .
/// </summary>
public partial class VJobCandidateEducationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEducationProfile"/> class.
    /// </summary>
    public VJobCandidateEducationProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VJobCandidateEducation>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationReadModel, Platy.AdventureWorks.Repository.Domain.Models.VJobCandidateEducationUpdateModel>();

    }

}
