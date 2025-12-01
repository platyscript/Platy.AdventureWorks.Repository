using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VIndividualCustomer"/> .
/// </summary>
public partial class VIndividualCustomerProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VIndividualCustomerProfile"/> class.
    /// </summary>
    public VIndividualCustomerProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer, Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer, Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer, Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VIndividualCustomer>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerReadModel, Platy.AdventureWorks.Repository.Domain.Models.VIndividualCustomerUpdateModel>();

    }

}
