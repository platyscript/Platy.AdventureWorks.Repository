using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ContactType"/> .
/// </summary>
public partial class ContactTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactTypeProfile"/> class.
    /// </summary>
    public ContactTypeProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ContactType, Platy.AdventureWorks.Repository.Domain.Models.ContactTypeReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ContactTypeCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ContactType>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ContactType, Platy.AdventureWorks.Repository.Domain.Models.ContactTypeCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ContactType, Platy.AdventureWorks.Repository.Domain.Models.ContactTypeUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ContactTypeUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ContactType>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ContactTypeReadModel, Platy.AdventureWorks.Repository.Domain.Models.ContactTypeUpdateModel>();

    }

}
