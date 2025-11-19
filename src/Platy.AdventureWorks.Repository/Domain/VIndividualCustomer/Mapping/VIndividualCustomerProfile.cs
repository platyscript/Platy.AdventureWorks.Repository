using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VIndividualCustomer" /> .
/// </summary>
public class VIndividualCustomerProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VIndividualCustomerProfile" /> class.
  /// </summary>
  public VIndividualCustomerProfile()
  {
    CreateMap<VIndividualCustomer, VIndividualCustomerReadModel>();

    CreateMap<VIndividualCustomerCreateModel, VIndividualCustomer>();

    CreateMap<VIndividualCustomer, VIndividualCustomerCreateModel>();

    CreateMap<VIndividualCustomer, VIndividualCustomerUpdateModel>();

    CreateMap<VIndividualCustomerUpdateModel, VIndividualCustomer>();

    CreateMap<VIndividualCustomerReadModel, VIndividualCustomerUpdateModel>();
  }
}
