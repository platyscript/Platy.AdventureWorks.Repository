using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTerritoryHistory"/> .
/// </summary>
public partial class SalesTerritoryHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryHistoryProfile"/> class.
    /// </summary>
    public SalesTerritoryHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryUpdateModel>();

    }

}
