using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SpecialOffer" /> .
/// </summary>
public class SpecialOfferProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SpecialOfferProfile" /> class.
  /// </summary>
  public SpecialOfferProfile()
  {
    CreateMap<SpecialOffer, SpecialOfferReadModel>();

    CreateMap<SpecialOfferCreateModel, SpecialOffer>();

    CreateMap<SpecialOffer, SpecialOfferCreateModel>();

    CreateMap<SpecialOffer, SpecialOfferUpdateModel>();

    CreateMap<SpecialOfferUpdateModel, SpecialOffer>();

    CreateMap<SpecialOfferReadModel, SpecialOfferUpdateModel>();
  }
}
