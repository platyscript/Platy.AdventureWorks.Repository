using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Address" /> .
/// </summary>
public class AddressProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="AddressProfile" /> class.
  /// </summary>
  public AddressProfile()
  {
    CreateMap<Address, AddressReadModel>();

    CreateMap<AddressCreateModel, Address>();

    CreateMap<Address, AddressCreateModel>();

    CreateMap<Address, AddressUpdateModel>();

    CreateMap<AddressUpdateModel, Address>();

    CreateMap<AddressReadModel, AddressUpdateModel>();
  }
}
