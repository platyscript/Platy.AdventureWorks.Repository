using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="AddressType" /> .
/// </summary>
public class AddressTypeProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="AddressTypeProfile" /> class.
  /// </summary>
  public AddressTypeProfile()
  {
    CreateMap<AddressType, AddressTypeReadModel>();

    CreateMap<AddressTypeCreateModel, AddressType>();

    CreateMap<AddressType, AddressTypeCreateModel>();

    CreateMap<AddressType, AddressTypeUpdateModel>();

    CreateMap<AddressTypeUpdateModel, AddressType>();

    CreateMap<AddressTypeReadModel, AddressTypeUpdateModel>();
  }
}
