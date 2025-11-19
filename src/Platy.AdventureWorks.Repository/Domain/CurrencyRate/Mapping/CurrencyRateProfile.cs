using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="CurrencyRate" /> .
/// </summary>
public class CurrencyRateProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CurrencyRateProfile" /> class.
  /// </summary>
  public CurrencyRateProfile()
  {
    CreateMap<CurrencyRate, CurrencyRateReadModel>();

    CreateMap<CurrencyRateCreateModel, CurrencyRate>();

    CreateMap<CurrencyRate, CurrencyRateCreateModel>();

    CreateMap<CurrencyRate, CurrencyRateUpdateModel>();

    CreateMap<CurrencyRateUpdateModel, CurrencyRate>();

    CreateMap<CurrencyRateReadModel, CurrencyRateUpdateModel>();
  }
}
