using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="SpecialOfferProduct" /> .
/// </summary>
public class SpecialOfferProductProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SpecialOfferProductProfile" /> class.
  /// </summary>
  public SpecialOfferProductProfile()
  {
    CreateMap<SpecialOfferProduct, SpecialOfferProductReadModel>();

    CreateMap<SpecialOfferProductCreateModel, SpecialOfferProduct>();

    CreateMap<SpecialOfferProduct, SpecialOfferProductCreateModel>();

    CreateMap<SpecialOfferProduct, SpecialOfferProductUpdateModel>();

    CreateMap<SpecialOfferProductUpdateModel, SpecialOfferProduct>();

    CreateMap<SpecialOfferProductReadModel, SpecialOfferProductUpdateModel>();
  }
}
