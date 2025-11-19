using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VStoreWithContacts" /> .
/// </summary>
public class VStoreWithContactsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStoreWithContactsProfile" /> class.
  /// </summary>
  public VStoreWithContactsProfile()
  {
    CreateMap<VStoreWithContacts, VStoreWithContactsReadModel>();

    CreateMap<VStoreWithContactsCreateModel, VStoreWithContacts>();

    CreateMap<VStoreWithContacts, VStoreWithContactsCreateModel>();

    CreateMap<VStoreWithContacts, VStoreWithContactsUpdateModel>();

    CreateMap<VStoreWithContactsUpdateModel, VStoreWithContacts>();

    CreateMap<VStoreWithContactsReadModel, VStoreWithContactsUpdateModel>();
  }
}
