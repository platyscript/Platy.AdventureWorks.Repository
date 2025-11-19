using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VProductModelCatalogDescription" /> .
/// </summary>
public class VProductModelCatalogDescriptionProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelCatalogDescriptionProfile" /> class.
  /// </summary>
  public VProductModelCatalogDescriptionProfile()
  {
    CreateMap<VProductModelCatalogDescription, VProductModelCatalogDescriptionReadModel>();

    CreateMap<VProductModelCatalogDescriptionCreateModel, VProductModelCatalogDescription>();

    CreateMap<VProductModelCatalogDescription, VProductModelCatalogDescriptionCreateModel>();

    CreateMap<VProductModelCatalogDescription, VProductModelCatalogDescriptionUpdateModel>();

    CreateMap<VProductModelCatalogDescriptionUpdateModel, VProductModelCatalogDescription>();

    CreateMap<VProductModelCatalogDescriptionReadModel, VProductModelCatalogDescriptionUpdateModel>();
  }
}
