using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="BusinessEntityContact" /> .
/// </summary>
public class BusinessEntityContactProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityContactProfile" /> class.
  /// </summary>
  public BusinessEntityContactProfile()
  {
    CreateMap<BusinessEntityContact, BusinessEntityContactReadModel>();

    CreateMap<BusinessEntityContactCreateModel, BusinessEntityContact>();

    CreateMap<BusinessEntityContact, BusinessEntityContactCreateModel>();

    CreateMap<BusinessEntityContact, BusinessEntityContactUpdateModel>();

    CreateMap<BusinessEntityContactUpdateModel, BusinessEntityContact>();

    CreateMap<BusinessEntityContactReadModel, BusinessEntityContactUpdateModel>();
  }
}
