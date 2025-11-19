using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesTaxRate" /> .
/// </summary>
public class SalesTaxRateProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesTaxRateProfile" /> class.
  /// </summary>
  public SalesTaxRateProfile()
  {
    CreateMap<SalesTaxRate, SalesTaxRateReadModel>();

    CreateMap<SalesTaxRateCreateModel, SalesTaxRate>();

    CreateMap<SalesTaxRate, SalesTaxRateCreateModel>();

    CreateMap<SalesTaxRate, SalesTaxRateUpdateModel>();

    CreateMap<SalesTaxRateUpdateModel, SalesTaxRate>();

    CreateMap<SalesTaxRateReadModel, SalesTaxRateUpdateModel>();
  }
}
