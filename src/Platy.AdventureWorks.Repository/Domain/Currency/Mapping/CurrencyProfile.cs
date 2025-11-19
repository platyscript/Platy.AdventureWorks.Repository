using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Currency" /> .
/// </summary>
public class CurrencyProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CurrencyProfile" /> class.
  /// </summary>
  public CurrencyProfile()
  {
    CreateMap<Currency, CurrencyReadModel>();

    CreateMap<CurrencyCreateModel, Currency>();

    CreateMap<Currency, CurrencyCreateModel>();

    CreateMap<Currency, CurrencyUpdateModel>();

    CreateMap<CurrencyUpdateModel, Currency>();

    CreateMap<CurrencyReadModel, CurrencyUpdateModel>();
  }
}
