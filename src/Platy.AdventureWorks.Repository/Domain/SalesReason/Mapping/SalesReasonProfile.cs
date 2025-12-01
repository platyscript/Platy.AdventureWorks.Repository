using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesReason"/> .
/// </summary>
public partial class SalesReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesReasonProfile"/> class.
    /// </summary>
    public SalesReasonProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesReason, Platy.AdventureWorks.Repository.Domain.Models.SalesReasonReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesReasonCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesReason>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesReason, Platy.AdventureWorks.Repository.Domain.Models.SalesReasonCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesReason, Platy.AdventureWorks.Repository.Domain.Models.SalesReasonUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesReasonUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesReason>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesReasonReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesReasonUpdateModel>();

    }

}
