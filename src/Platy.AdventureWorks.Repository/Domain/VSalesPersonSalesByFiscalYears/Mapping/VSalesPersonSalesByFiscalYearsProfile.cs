using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VSalesPersonSalesByFiscalYears" /> .
/// </summary>
public class VSalesPersonSalesByFiscalYearsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYearsProfile" /> class.
  /// </summary>
  public VSalesPersonSalesByFiscalYearsProfile()
  {
    CreateMap<VSalesPersonSalesByFiscalYears, VSalesPersonSalesByFiscalYearsReadModel>();

    CreateMap<VSalesPersonSalesByFiscalYearsCreateModel, VSalesPersonSalesByFiscalYears>();

    CreateMap<VSalesPersonSalesByFiscalYears, VSalesPersonSalesByFiscalYearsCreateModel>();

    CreateMap<VSalesPersonSalesByFiscalYears, VSalesPersonSalesByFiscalYearsUpdateModel>();

    CreateMap<VSalesPersonSalesByFiscalYearsUpdateModel, VSalesPersonSalesByFiscalYears>();

    CreateMap<VSalesPersonSalesByFiscalYearsReadModel, VSalesPersonSalesByFiscalYearsUpdateModel>();
  }
}
