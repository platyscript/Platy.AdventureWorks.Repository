using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Address"/> .
/// </summary>
public partial class AddressProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressProfile"/> class.
    /// </summary>
    public AddressProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Address, Platy.AdventureWorks.Repository.Domain.Models.AddressReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.AddressCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Address>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Address, Platy.AdventureWorks.Repository.Domain.Models.AddressCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Address, Platy.AdventureWorks.Repository.Domain.Models.AddressUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.AddressUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Address>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.AddressReadModel, Platy.AdventureWorks.Repository.Domain.Models.AddressUpdateModel>();

    }

}
