using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SalesReason" /> .
/// </summary>
public class SalesReasonProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesReasonProfile" /> class.
  /// </summary>
  public SalesReasonProfile()
  {
    CreateMap<SalesReason, SalesReasonReadModel>();

    CreateMap<SalesReasonCreateModel, SalesReason>();

    CreateMap<SalesReason, SalesReasonCreateModel>();

    CreateMap<SalesReason, SalesReasonUpdateModel>();

    CreateMap<SalesReasonUpdateModel, SalesReason>();

    CreateMap<SalesReasonReadModel, SalesReasonUpdateModel>();
  }
}
