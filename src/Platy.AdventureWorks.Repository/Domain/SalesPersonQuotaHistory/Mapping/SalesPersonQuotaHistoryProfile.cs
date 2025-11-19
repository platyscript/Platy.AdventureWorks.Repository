using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesPersonQuotaHistory" /> .
/// </summary>
public class SalesPersonQuotaHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesPersonQuotaHistoryProfile" /> class.
  /// </summary>
  public SalesPersonQuotaHistoryProfile()
  {
    CreateMap<SalesPersonQuotaHistory, SalesPersonQuotaHistoryReadModel>();

    CreateMap<SalesPersonQuotaHistoryCreateModel, SalesPersonQuotaHistory>();

    CreateMap<SalesPersonQuotaHistory, SalesPersonQuotaHistoryCreateModel>();

    CreateMap<SalesPersonQuotaHistory, SalesPersonQuotaHistoryUpdateModel>();

    CreateMap<SalesPersonQuotaHistoryUpdateModel, SalesPersonQuotaHistory>();

    CreateMap<SalesPersonQuotaHistoryReadModel, SalesPersonQuotaHistoryUpdateModel>();
  }
}
