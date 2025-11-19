using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Vendor" /> .
/// </summary>
public class VendorProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VendorProfile" /> class.
  /// </summary>
  public VendorProfile()
  {
    CreateMap<Vendor, VendorReadModel>();

    CreateMap<VendorCreateModel, Vendor>();

    CreateMap<Vendor, VendorCreateModel>();

    CreateMap<Vendor, VendorUpdateModel>();

    CreateMap<VendorUpdateModel, Vendor>();

    CreateMap<VendorReadModel, VendorUpdateModel>();
  }
}
