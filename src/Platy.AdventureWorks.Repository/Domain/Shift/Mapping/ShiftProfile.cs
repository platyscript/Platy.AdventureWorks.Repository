using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Shift" /> .
/// </summary>
public class ShiftProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShiftProfile" /> class.
  /// </summary>
  public ShiftProfile()
  {
    CreateMap<Shift, ShiftReadModel>();

    CreateMap<ShiftCreateModel, Shift>();

    CreateMap<Shift, ShiftCreateModel>();

    CreateMap<Shift, ShiftUpdateModel>();

    CreateMap<ShiftUpdateModel, Shift>();

    CreateMap<ShiftReadModel, ShiftUpdateModel>();
  }
}
