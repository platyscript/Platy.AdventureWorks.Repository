using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CountryRegionCurrency"/> .
/// </summary>
public partial class CountryRegionCurrencyProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionCurrencyProfile"/> class.
    /// </summary>
    public CountryRegionCurrencyProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyCreateModel, Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyReadModel, Platy.AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyUpdateModel>();

    }

}
