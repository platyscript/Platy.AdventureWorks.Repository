using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PersonPhone"/> .
/// </summary>
public partial class PersonPhoneProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonPhoneProfile"/> class.
    /// </summary>
    public PersonPhoneProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PersonPhone, Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneCreateModel, Platy.AdventureWorks.Repository.Data.Entities.PersonPhone>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PersonPhone, Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PersonPhone, Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.PersonPhone>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneReadModel, Platy.AdventureWorks.Repository.Domain.Models.PersonPhoneUpdateModel>();

    }

}
