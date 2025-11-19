using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="CountryRegionCurrency" /> .
/// </summary>
public class CountryRegionCurrencyProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CountryRegionCurrencyProfile" /> class.
  /// </summary>
  public CountryRegionCurrencyProfile()
  {
    CreateMap<CountryRegionCurrency, CountryRegionCurrencyReadModel>();

    CreateMap<CountryRegionCurrencyCreateModel, CountryRegionCurrency>();

    CreateMap<CountryRegionCurrency, CountryRegionCurrencyCreateModel>();

    CreateMap<CountryRegionCurrency, CountryRegionCurrencyUpdateModel>();

    CreateMap<CountryRegionCurrencyUpdateModel, CountryRegionCurrency>();

    CreateMap<CountryRegionCurrencyReadModel, CountryRegionCurrencyUpdateModel>();
  }
}
