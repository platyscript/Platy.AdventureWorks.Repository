using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CurrencyRate"/> .
/// </summary>
public partial class CurrencyRateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRateProfile"/> class.
    /// </summary>
    public CurrencyRateProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate, Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateCreateModel, Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate, Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate, Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.CurrencyRate>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateReadModel, Platy.AdventureWorks.Repository.Domain.Models.CurrencyRateUpdateModel>();

    }

}
