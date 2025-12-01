using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Person"/> .
/// </summary>
public partial class PersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonProfile"/> class.
    /// </summary>
    public PersonProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Person, Platy.AdventureWorks.Repository.Domain.Models.PersonReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Person>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Person, Platy.AdventureWorks.Repository.Domain.Models.PersonCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Person, Platy.AdventureWorks.Repository.Domain.Models.PersonUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Person>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonReadModel, Platy.AdventureWorks.Repository.Domain.Models.PersonUpdateModel>();

    }

}
