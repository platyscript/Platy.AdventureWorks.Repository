using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Customer"/> .
/// </summary>
public partial class CustomerProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerProfile"/> class.
    /// </summary>
    public CustomerProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Customer, Platy.AdventureWorks.Repository.Domain.Models.CustomerReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CustomerCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Customer>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Customer, Platy.AdventureWorks.Repository.Domain.Models.CustomerCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Customer, Platy.AdventureWorks.Repository.Domain.Models.CustomerUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CustomerUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Customer>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CustomerReadModel, Platy.AdventureWorks.Repository.Domain.Models.CustomerUpdateModel>();

    }

}
