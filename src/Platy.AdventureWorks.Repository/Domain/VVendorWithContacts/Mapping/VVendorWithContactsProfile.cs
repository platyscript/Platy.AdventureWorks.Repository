using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VVendorWithContacts" /> .
/// </summary>
public class VVendorWithContactsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VVendorWithContactsProfile" /> class.
  /// </summary>
  public VVendorWithContactsProfile()
  {
    CreateMap<VVendorWithContacts, VVendorWithContactsReadModel>();

    CreateMap<VVendorWithContactsCreateModel, VVendorWithContacts>();

    CreateMap<VVendorWithContacts, VVendorWithContactsCreateModel>();

    CreateMap<VVendorWithContacts, VVendorWithContactsUpdateModel>();

    CreateMap<VVendorWithContactsUpdateModel, VVendorWithContacts>();

    CreateMap<VVendorWithContactsReadModel, VVendorWithContactsUpdateModel>();
  }
}
