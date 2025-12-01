using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmailAddress"/> .
/// </summary>
public partial class EmailAddressProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAddressProfile"/> class.
    /// </summary>
    public EmailAddressProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmailAddress, Platy.AdventureWorks.Repository.Domain.Models.EmailAddressReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmailAddressCreateModel, Platy.AdventureWorks.Repository.Data.Entities.EmailAddress>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmailAddress, Platy.AdventureWorks.Repository.Domain.Models.EmailAddressCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmailAddress, Platy.AdventureWorks.Repository.Domain.Models.EmailAddressUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmailAddressUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.EmailAddress>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmailAddressReadModel, Platy.AdventureWorks.Repository.Domain.Models.EmailAddressUpdateModel>();

    }

}
