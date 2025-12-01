using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Culture"/> .
/// </summary>
public partial class CultureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CultureProfile"/> class.
    /// </summary>
    public CultureProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Culture, Platy.AdventureWorks.Repository.Domain.Models.CultureReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CultureCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Culture>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Culture, Platy.AdventureWorks.Repository.Domain.Models.CultureCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Culture, Platy.AdventureWorks.Repository.Domain.Models.CultureUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CultureUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Culture>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CultureReadModel, Platy.AdventureWorks.Repository.Domain.Models.CultureUpdateModel>();

    }

}
