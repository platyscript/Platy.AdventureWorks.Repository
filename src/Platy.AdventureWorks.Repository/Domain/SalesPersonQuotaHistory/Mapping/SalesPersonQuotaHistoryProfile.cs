using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesPersonQuotaHistory"/> .
/// </summary>
public partial class SalesPersonQuotaHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonQuotaHistoryProfile"/> class.
    /// </summary>
    public SalesPersonQuotaHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryUpdateModel>();

    }

}
