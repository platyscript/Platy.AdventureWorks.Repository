using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesOrderDetail" /> .
/// </summary>
public class SalesOrderDetailProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderDetailProfile" /> class.
  /// </summary>
  public SalesOrderDetailProfile()
  {
    CreateMap<SalesOrderDetail, SalesOrderDetailReadModel>();

    CreateMap<SalesOrderDetailCreateModel, SalesOrderDetail>();

    CreateMap<SalesOrderDetail, SalesOrderDetailCreateModel>();

    CreateMap<SalesOrderDetail, SalesOrderDetailUpdateModel>();

    CreateMap<SalesOrderDetailUpdateModel, SalesOrderDetail>();

    CreateMap<SalesOrderDetailReadModel, SalesOrderDetailUpdateModel>();
  }
}
