using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SpecialOffer"/> .
/// </summary>
public partial class SpecialOfferProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProfile"/> class.
    /// </summary>
    public SpecialOfferProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SpecialOffer>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferReadModel, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferUpdateModel>();

    }

}
