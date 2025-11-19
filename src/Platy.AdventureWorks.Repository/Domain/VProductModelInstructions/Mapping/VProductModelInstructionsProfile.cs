using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VProductModelInstructions" /> .
/// </summary>
public class VProductModelInstructionsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelInstructionsProfile" /> class.
  /// </summary>
  public VProductModelInstructionsProfile()
  {
    CreateMap<VProductModelInstructions, VProductModelInstructionsReadModel>();

    CreateMap<VProductModelInstructionsCreateModel, VProductModelInstructions>();

    CreateMap<VProductModelInstructions, VProductModelInstructionsCreateModel>();

    CreateMap<VProductModelInstructions, VProductModelInstructionsUpdateModel>();

    CreateMap<VProductModelInstructionsUpdateModel, VProductModelInstructions>();

    CreateMap<VProductModelInstructionsReadModel, VProductModelInstructionsUpdateModel>();
  }
}
