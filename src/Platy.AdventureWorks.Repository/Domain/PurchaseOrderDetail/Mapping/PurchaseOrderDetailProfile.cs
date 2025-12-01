using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PurchaseOrderDetail"/> .
/// </summary>
public partial class PurchaseOrderDetailProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderDetailProfile"/> class.
    /// </summary>
    public PurchaseOrderDetailProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailCreateModel, Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailReadModel, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailUpdateModel>();

    }

}
