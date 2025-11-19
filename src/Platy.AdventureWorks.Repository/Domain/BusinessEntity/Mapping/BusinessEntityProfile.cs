using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="BusinessEntity" /> .
/// </summary>
public class BusinessEntityProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityProfile" /> class.
  /// </summary>
  public BusinessEntityProfile()
  {
    CreateMap<BusinessEntity, BusinessEntityReadModel>();

    CreateMap<BusinessEntityCreateModel, BusinessEntity>();

    CreateMap<BusinessEntity, BusinessEntityCreateModel>();

    CreateMap<BusinessEntity, BusinessEntityUpdateModel>();

    CreateMap<BusinessEntityUpdateModel, BusinessEntity>();

    CreateMap<BusinessEntityReadModel, BusinessEntityUpdateModel>();
  }
}
