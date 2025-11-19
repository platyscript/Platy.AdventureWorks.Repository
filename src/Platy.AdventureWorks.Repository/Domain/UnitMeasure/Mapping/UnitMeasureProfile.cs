using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="UnitMeasure" /> .
/// </summary>
public class UnitMeasureProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="UnitMeasureProfile" /> class.
  /// </summary>
  public UnitMeasureProfile()
  {
    CreateMap<UnitMeasure, UnitMeasureReadModel>();

    CreateMap<UnitMeasureCreateModel, UnitMeasure>();

    CreateMap<UnitMeasure, UnitMeasureCreateModel>();

    CreateMap<UnitMeasure, UnitMeasureUpdateModel>();

    CreateMap<UnitMeasureUpdateModel, UnitMeasure>();

    CreateMap<UnitMeasureReadModel, UnitMeasureUpdateModel>();
  }
}
