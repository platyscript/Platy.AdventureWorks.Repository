using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VStoreWithAddresses" /> .
/// </summary>
public class VStoreWithAddressesProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VStoreWithAddressesProfile" /> class.
  /// </summary>
  public VStoreWithAddressesProfile()
  {
    CreateMap<VStoreWithAddresses, VStoreWithAddressesReadModel>();

    CreateMap<VStoreWithAddressesCreateModel, VStoreWithAddresses>();

    CreateMap<VStoreWithAddresses, VStoreWithAddressesCreateModel>();

    CreateMap<VStoreWithAddresses, VStoreWithAddressesUpdateModel>();

    CreateMap<VStoreWithAddressesUpdateModel, VStoreWithAddresses>();

    CreateMap<VStoreWithAddressesReadModel, VStoreWithAddressesUpdateModel>();
  }
}
