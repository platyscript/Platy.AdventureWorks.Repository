using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Currency"/> .
/// </summary>
public partial class CurrencyProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyProfile"/> class.
    /// </summary>
    public CurrencyProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Currency, Platy.AdventureWorks.Repository.Domain.Models.CurrencyReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CurrencyCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Currency>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Currency, Platy.AdventureWorks.Repository.Domain.Models.CurrencyCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Currency, Platy.AdventureWorks.Repository.Domain.Models.CurrencyUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CurrencyUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Currency>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CurrencyReadModel, Platy.AdventureWorks.Repository.Domain.Models.CurrencyUpdateModel>();

    }

}
