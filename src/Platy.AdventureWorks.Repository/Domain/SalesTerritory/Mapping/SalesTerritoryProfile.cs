using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTerritory"/> .
/// </summary>
public partial class SalesTerritoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryProfile"/> class.
    /// </summary>
    public SalesTerritoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryUpdateModel>();

    }

}
