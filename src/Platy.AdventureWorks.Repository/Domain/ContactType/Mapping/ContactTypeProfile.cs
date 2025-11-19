using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ContactType" /> .
/// </summary>
public class ContactTypeProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ContactTypeProfile" /> class.
  /// </summary>
  public ContactTypeProfile()
  {
    CreateMap<ContactType, ContactTypeReadModel>();

    CreateMap<ContactTypeCreateModel, ContactType>();

    CreateMap<ContactType, ContactTypeCreateModel>();

    CreateMap<ContactType, ContactTypeUpdateModel>();

    CreateMap<ContactTypeUpdateModel, ContactType>();

    CreateMap<ContactTypeReadModel, ContactTypeUpdateModel>();
  }
}
