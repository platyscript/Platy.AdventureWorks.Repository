using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ScrapReason"/> .
/// </summary>
public partial class ScrapReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrapReasonProfile"/> class.
    /// </summary>
    public ScrapReasonProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ScrapReason, Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ScrapReason>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ScrapReason, Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ScrapReason, Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ScrapReason>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonReadModel, Platy.AdventureWorks.Repository.Domain.Models.ScrapReasonUpdateModel>();

    }

}
