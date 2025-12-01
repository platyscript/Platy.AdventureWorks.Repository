using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VVendorWithContacts"/> .
/// </summary>
public partial class VVendorWithContactsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VVendorWithContactsProfile"/> class.
    /// </summary>
    public VVendorWithContactsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VVendorWithContacts>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsReadModel, Platy.AdventureWorks.Repository.Domain.Models.VVendorWithContactsUpdateModel>();

    }

}
