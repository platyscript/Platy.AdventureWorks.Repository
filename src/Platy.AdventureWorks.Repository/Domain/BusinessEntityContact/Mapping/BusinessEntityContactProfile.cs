using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BusinessEntityContact"/> .
/// </summary>
public partial class BusinessEntityContactProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityContactProfile"/> class.
    /// </summary>
    public BusinessEntityContactProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactCreateModel, Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityContact>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactReadModel, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityContactUpdateModel>();

    }

}
