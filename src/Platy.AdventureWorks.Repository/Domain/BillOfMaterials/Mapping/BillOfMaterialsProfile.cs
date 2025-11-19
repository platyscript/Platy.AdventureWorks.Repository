using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="BillOfMaterials" /> .
/// </summary>
public class BillOfMaterialsProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BillOfMaterialsProfile" /> class.
  /// </summary>
  public BillOfMaterialsProfile()
  {
    CreateMap<BillOfMaterials, BillOfMaterialsReadModel>();

    CreateMap<BillOfMaterialsCreateModel, BillOfMaterials>();

    CreateMap<BillOfMaterials, BillOfMaterialsCreateModel>();

    CreateMap<BillOfMaterials, BillOfMaterialsUpdateModel>();

    CreateMap<BillOfMaterialsUpdateModel, BillOfMaterials>();

    CreateMap<BillOfMaterialsReadModel, BillOfMaterialsUpdateModel>();
  }
}
