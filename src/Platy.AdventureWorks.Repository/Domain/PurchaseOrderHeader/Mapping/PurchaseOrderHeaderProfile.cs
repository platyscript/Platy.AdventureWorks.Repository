using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PurchaseOrderHeader"/> .
/// </summary>
public partial class PurchaseOrderHeaderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderHeaderProfile"/> class.
    /// </summary>
    public PurchaseOrderHeaderProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderCreateModel, Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderReadModel, Platy.AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderUpdateModel>();

    }

}
