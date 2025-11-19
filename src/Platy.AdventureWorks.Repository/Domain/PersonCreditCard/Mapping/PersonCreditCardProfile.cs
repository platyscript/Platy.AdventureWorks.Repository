using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="PersonCreditCard" /> .
/// </summary>
public class PersonCreditCardProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonCreditCardProfile" /> class.
  /// </summary>
  public PersonCreditCardProfile()
  {
    CreateMap<PersonCreditCard, PersonCreditCardReadModel>();

    CreateMap<PersonCreditCardCreateModel, PersonCreditCard>();

    CreateMap<PersonCreditCard, PersonCreditCardCreateModel>();

    CreateMap<PersonCreditCard, PersonCreditCardUpdateModel>();

    CreateMap<PersonCreditCardUpdateModel, PersonCreditCard>();

    CreateMap<PersonCreditCardReadModel, PersonCreditCardUpdateModel>();
  }
}
