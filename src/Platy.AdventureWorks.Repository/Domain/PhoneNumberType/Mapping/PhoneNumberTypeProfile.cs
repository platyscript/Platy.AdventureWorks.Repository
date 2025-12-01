using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PhoneNumberType"/> .
/// </summary>
public partial class PhoneNumberTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneNumberTypeProfile"/> class.
    /// </summary>
    public PhoneNumberTypeProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType, Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeCreateModel, Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType, Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType, Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.PhoneNumberType>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeReadModel, Platy.AdventureWorks.Repository.Domain.Models.PhoneNumberTypeUpdateModel>();

    }

}
