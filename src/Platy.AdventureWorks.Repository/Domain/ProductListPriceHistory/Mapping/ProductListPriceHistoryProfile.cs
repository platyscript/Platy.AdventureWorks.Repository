using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductListPriceHistory"/> .
/// </summary>
public partial class ProductListPriceHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListPriceHistoryProfile"/> class.
    /// </summary>
    public ProductListPriceHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductListPriceHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryUpdateModel>();

    }

}
