using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="AddressType"/> .
/// </summary>
public partial class AddressTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressTypeProfile"/> class.
    /// </summary>
    public AddressTypeProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.AddressType, Platy.AdventureWorks.Repository.Domain.Models.AddressTypeReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.AddressTypeCreateModel, Platy.AdventureWorks.Repository.Data.Entities.AddressType>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.AddressType, Platy.AdventureWorks.Repository.Domain.Models.AddressTypeCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.AddressType, Platy.AdventureWorks.Repository.Domain.Models.AddressTypeUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.AddressTypeUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.AddressType>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.AddressTypeReadModel, Platy.AdventureWorks.Repository.Domain.Models.AddressTypeUpdateModel>();

    }

}
