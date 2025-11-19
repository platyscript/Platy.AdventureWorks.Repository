using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Person" /> .
/// </summary>
public class PersonProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonProfile" /> class.
  /// </summary>
  public PersonProfile()
  {
    CreateMap<Person, PersonReadModel>();

    CreateMap<PersonCreateModel, Person>();

    CreateMap<Person, PersonCreateModel>();

    CreateMap<Person, PersonUpdateModel>();

    CreateMap<PersonUpdateModel, Person>();

    CreateMap<PersonReadModel, PersonUpdateModel>();
  }
}
