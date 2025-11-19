using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Location" /> .
/// </summary>
public class LocationProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="LocationProfile" /> class.
  /// </summary>
  public LocationProfile()
  {
    CreateMap<Location, LocationReadModel>();

    CreateMap<LocationCreateModel, Location>();

    CreateMap<Location, LocationCreateModel>();

    CreateMap<Location, LocationUpdateModel>();

    CreateMap<LocationUpdateModel, Location>();

    CreateMap<LocationReadModel, LocationUpdateModel>();
  }
}
