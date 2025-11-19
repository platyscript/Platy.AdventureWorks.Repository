using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="PurchaseOrderHeader" /> .
/// </summary>
public class PurchaseOrderHeaderProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderHeaderProfile" /> class.
  /// </summary>
  public PurchaseOrderHeaderProfile()
  {
    CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderReadModel>();

    CreateMap<PurchaseOrderHeaderCreateModel, PurchaseOrderHeader>();

    CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderCreateModel>();

    CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderUpdateModel>();

    CreateMap<PurchaseOrderHeaderUpdateModel, PurchaseOrderHeader>();

    CreateMap<PurchaseOrderHeaderReadModel, PurchaseOrderHeaderUpdateModel>();
  }
}
