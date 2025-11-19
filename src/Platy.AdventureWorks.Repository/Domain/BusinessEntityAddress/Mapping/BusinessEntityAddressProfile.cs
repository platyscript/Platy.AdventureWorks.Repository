using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="BusinessEntityAddress" /> .
/// </summary>
public class BusinessEntityAddressProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="BusinessEntityAddressProfile" /> class.
  /// </summary>
  public BusinessEntityAddressProfile()
  {
    CreateMap<BusinessEntityAddress, BusinessEntityAddressReadModel>();

    CreateMap<BusinessEntityAddressCreateModel, BusinessEntityAddress>();

    CreateMap<BusinessEntityAddress, BusinessEntityAddressCreateModel>();

    CreateMap<BusinessEntityAddress, BusinessEntityAddressUpdateModel>();

    CreateMap<BusinessEntityAddressUpdateModel, BusinessEntityAddress>();

    CreateMap<BusinessEntityAddressReadModel, BusinessEntityAddressUpdateModel>();
  }
}
