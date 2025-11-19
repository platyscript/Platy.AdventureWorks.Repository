using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="PurchaseOrderDetail" /> .
/// </summary>
public class PurchaseOrderDetailProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderDetailProfile" /> class.
  /// </summary>
  public PurchaseOrderDetailProfile()
  {
    CreateMap<PurchaseOrderDetail, PurchaseOrderDetailReadModel>();

    CreateMap<PurchaseOrderDetailCreateModel, PurchaseOrderDetail>();

    CreateMap<PurchaseOrderDetail, PurchaseOrderDetailCreateModel>();

    CreateMap<PurchaseOrderDetail, PurchaseOrderDetailUpdateModel>();

    CreateMap<PurchaseOrderDetailUpdateModel, PurchaseOrderDetail>();

    CreateMap<PurchaseOrderDetailReadModel, PurchaseOrderDetailUpdateModel>();
  }
}
