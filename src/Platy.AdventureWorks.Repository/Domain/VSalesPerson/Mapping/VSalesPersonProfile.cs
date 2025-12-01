using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VSalesPerson"/> .
/// </summary>
public partial class VSalesPersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonProfile"/> class.
    /// </summary>
    public VSalesPersonProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonReadModel, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonUpdateModel>();

    }

}
