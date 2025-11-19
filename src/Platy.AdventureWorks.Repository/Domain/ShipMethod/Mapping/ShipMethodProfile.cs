using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ShipMethod" /> .
/// </summary>
public class ShipMethodProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShipMethodProfile" /> class.
  /// </summary>
  public ShipMethodProfile()
  {
    CreateMap<ShipMethod, ShipMethodReadModel>();

    CreateMap<ShipMethodCreateModel, ShipMethod>();

    CreateMap<ShipMethod, ShipMethodCreateModel>();

    CreateMap<ShipMethod, ShipMethodUpdateModel>();

    CreateMap<ShipMethodUpdateModel, ShipMethod>();

    CreateMap<ShipMethodReadModel, ShipMethodUpdateModel>();
  }
}
