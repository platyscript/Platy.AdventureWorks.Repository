using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BusinessEntityAddress"/> .
/// </summary>
public partial class BusinessEntityAddressProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityAddressProfile"/> class.
    /// </summary>
    public BusinessEntityAddressProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressCreateModel, Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressReadModel, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityAddressUpdateModel>();

    }

}
