using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BusinessEntity"/> .
/// </summary>
public partial class BusinessEntityProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityProfile"/> class.
    /// </summary>
    public BusinessEntityProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityCreateModel, Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.BusinessEntity>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityReadModel, Platy.AdventureWorks.Repository.Domain.Models.BusinessEntityUpdateModel>();

    }

}
