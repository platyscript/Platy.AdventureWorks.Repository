using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ScrapReason" /> .
/// </summary>
public class ScrapReasonProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ScrapReasonProfile" /> class.
  /// </summary>
  public ScrapReasonProfile()
  {
    CreateMap<ScrapReason, ScrapReasonReadModel>();

    CreateMap<ScrapReasonCreateModel, ScrapReason>();

    CreateMap<ScrapReason, ScrapReasonCreateModel>();

    CreateMap<ScrapReason, ScrapReasonUpdateModel>();

    CreateMap<ScrapReasonUpdateModel, ScrapReason>();

    CreateMap<ScrapReasonReadModel, ScrapReasonUpdateModel>();
  }
}
