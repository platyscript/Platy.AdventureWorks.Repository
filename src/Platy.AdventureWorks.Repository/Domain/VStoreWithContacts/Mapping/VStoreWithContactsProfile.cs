using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithContacts"/> .
/// </summary>
public partial class VStoreWithContactsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithContactsProfile"/> class.
    /// </summary>
    public VStoreWithContactsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsReadModel, Platy.AdventureWorks.Repository.Domain.Models.VStoreWithContactsUpdateModel>();

    }

}
