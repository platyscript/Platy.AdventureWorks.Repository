using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Store" /> .
/// </summary>
public class StoreProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="StoreProfile" /> class.
  /// </summary>
  public StoreProfile()
  {
    CreateMap<Store, StoreReadModel>();

    CreateMap<StoreCreateModel, Store>();

    CreateMap<Store, StoreCreateModel>();

    CreateMap<Store, StoreUpdateModel>();

    CreateMap<StoreUpdateModel, Store>();

    CreateMap<StoreReadModel, StoreUpdateModel>();
  }
}
