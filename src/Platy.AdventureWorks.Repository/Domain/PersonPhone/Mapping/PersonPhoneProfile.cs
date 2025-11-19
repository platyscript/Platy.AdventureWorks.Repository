using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="PersonPhone" /> .
/// </summary>
public class PersonPhoneProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonPhoneProfile" /> class.
  /// </summary>
  public PersonPhoneProfile()
  {
    CreateMap<PersonPhone, PersonPhoneReadModel>();

    CreateMap<PersonPhoneCreateModel, PersonPhone>();

    CreateMap<PersonPhone, PersonPhoneCreateModel>();

    CreateMap<PersonPhone, PersonPhoneUpdateModel>();

    CreateMap<PersonPhoneUpdateModel, PersonPhone>();

    CreateMap<PersonPhoneReadModel, PersonPhoneUpdateModel>();
  }
}
