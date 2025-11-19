using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="CreditCard" /> .
/// </summary>
public class CreditCardProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CreditCardProfile" /> class.
  /// </summary>
  public CreditCardProfile()
  {
    CreateMap<CreditCard, CreditCardReadModel>();

    CreateMap<CreditCardCreateModel, CreditCard>();

    CreateMap<CreditCard, CreditCardCreateModel>();

    CreateMap<CreditCard, CreditCardUpdateModel>();

    CreateMap<CreditCardUpdateModel, CreditCard>();

    CreateMap<CreditCardReadModel, CreditCardUpdateModel>();
  }
}
