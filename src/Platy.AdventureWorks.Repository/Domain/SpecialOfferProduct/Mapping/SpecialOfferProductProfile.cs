using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SpecialOfferProduct"/> .
/// </summary>
public partial class SpecialOfferProductProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProductProfile"/> class.
    /// </summary>
    public SpecialOfferProductProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SpecialOfferProduct>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductReadModel, Platy.AdventureWorks.Repository.Domain.Models.SpecialOfferProductUpdateModel>();

    }

}
