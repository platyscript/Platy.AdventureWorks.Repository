using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductCostHistory"/> .
/// </summary>
public partial class ProductCostHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCostHistoryProfile"/> class.
    /// </summary>
    public ProductCostHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory, Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory, Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory, Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductCostHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductCostHistoryUpdateModel>();

    }

}
