using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VVendorWithAddresses" /> .
/// </summary>
public class VVendorWithAddressesProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VVendorWithAddressesProfile" /> class.
  /// </summary>
  public VVendorWithAddressesProfile()
  {
    CreateMap<VVendorWithAddresses, VVendorWithAddressesReadModel>();

    CreateMap<VVendorWithAddressesCreateModel, VVendorWithAddresses>();

    CreateMap<VVendorWithAddresses, VVendorWithAddressesCreateModel>();

    CreateMap<VVendorWithAddresses, VVendorWithAddressesUpdateModel>();

    CreateMap<VVendorWithAddressesUpdateModel, VVendorWithAddresses>();

    CreateMap<VVendorWithAddressesReadModel, VVendorWithAddressesUpdateModel>();
  }
}
