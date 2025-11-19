using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VSalesPerson" /> .
/// </summary>
public class VSalesPersonProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VSalesPersonProfile" /> class.
  /// </summary>
  public VSalesPersonProfile()
  {
    CreateMap<VSalesPerson, VSalesPersonReadModel>();

    CreateMap<VSalesPersonCreateModel, VSalesPerson>();

    CreateMap<VSalesPerson, VSalesPersonCreateModel>();

    CreateMap<VSalesPerson, VSalesPersonUpdateModel>();

    CreateMap<VSalesPersonUpdateModel, VSalesPerson>();

    CreateMap<VSalesPersonReadModel, VSalesPersonUpdateModel>();
  }
}
