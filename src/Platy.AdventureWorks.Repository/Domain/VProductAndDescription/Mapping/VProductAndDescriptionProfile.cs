using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VProductAndDescription" /> .
/// </summary>
public class VProductAndDescriptionProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductAndDescriptionProfile" /> class.
  /// </summary>
  public VProductAndDescriptionProfile()
  {
    CreateMap<VProductAndDescription, VProductAndDescriptionReadModel>();

    CreateMap<VProductAndDescriptionCreateModel, VProductAndDescription>();

    CreateMap<VProductAndDescription, VProductAndDescriptionCreateModel>();

    CreateMap<VProductAndDescription, VProductAndDescriptionUpdateModel>();

    CreateMap<VProductAndDescriptionUpdateModel, VProductAndDescription>();

    CreateMap<VProductAndDescriptionReadModel, VProductAndDescriptionUpdateModel>();
  }
}
