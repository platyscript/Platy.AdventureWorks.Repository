using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderDetail"/> .
/// </summary>
public partial class SalesOrderDetailProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetailProfile"/> class.
    /// </summary>
    public SalesOrderDetailProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesOrderDetail>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderDetailUpdateModel>();

    }

}
