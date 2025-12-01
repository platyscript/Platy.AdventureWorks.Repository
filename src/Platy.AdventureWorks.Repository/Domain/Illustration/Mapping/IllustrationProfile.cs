using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Illustration"/> .
/// </summary>
public partial class IllustrationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IllustrationProfile"/> class.
    /// </summary>
    public IllustrationProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Illustration, Platy.AdventureWorks.Repository.Domain.Models.IllustrationReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.IllustrationCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Illustration>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Illustration, Platy.AdventureWorks.Repository.Domain.Models.IllustrationCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Illustration, Platy.AdventureWorks.Repository.Domain.Models.IllustrationUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.IllustrationUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Illustration>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.IllustrationReadModel, Platy.AdventureWorks.Repository.Domain.Models.IllustrationUpdateModel>();

    }

}
