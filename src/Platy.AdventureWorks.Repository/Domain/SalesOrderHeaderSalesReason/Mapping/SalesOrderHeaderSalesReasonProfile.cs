using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderHeaderSalesReason"/> .
/// </summary>
public partial class SalesOrderHeaderSalesReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonProfile"/> class.
    /// </summary>
    public SalesOrderHeaderSalesReasonProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonUpdateModel>();

    }

}
