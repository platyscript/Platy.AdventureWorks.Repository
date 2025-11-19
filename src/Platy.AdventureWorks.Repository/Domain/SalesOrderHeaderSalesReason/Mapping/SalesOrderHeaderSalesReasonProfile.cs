using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesOrderHeaderSalesReason" /> .
/// </summary>
public class SalesOrderHeaderSalesReasonProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonProfile" /> class.
  /// </summary>
  public SalesOrderHeaderSalesReasonProfile()
  {
    CreateMap<SalesOrderHeaderSalesReason, SalesOrderHeaderSalesReasonReadModel>();

    CreateMap<SalesOrderHeaderSalesReasonCreateModel, SalesOrderHeaderSalesReason>();

    CreateMap<SalesOrderHeaderSalesReason, SalesOrderHeaderSalesReasonCreateModel>();

    CreateMap<SalesOrderHeaderSalesReason, SalesOrderHeaderSalesReasonUpdateModel>();

    CreateMap<SalesOrderHeaderSalesReasonUpdateModel, SalesOrderHeaderSalesReason>();

    CreateMap<SalesOrderHeaderSalesReasonReadModel, SalesOrderHeaderSalesReasonUpdateModel>();
  }
}
