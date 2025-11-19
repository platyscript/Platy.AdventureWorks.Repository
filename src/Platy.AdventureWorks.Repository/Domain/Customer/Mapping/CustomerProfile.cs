using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Customer" /> .
/// </summary>
public class CustomerProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CustomerProfile" /> class.
  /// </summary>
  public CustomerProfile()
  {
    CreateMap<Customer, CustomerReadModel>();

    CreateMap<CustomerCreateModel, Customer>();

    CreateMap<Customer, CustomerCreateModel>();

    CreateMap<Customer, CustomerUpdateModel>();

    CreateMap<CustomerUpdateModel, Customer>();

    CreateMap<CustomerReadModel, CustomerUpdateModel>();
  }
}
