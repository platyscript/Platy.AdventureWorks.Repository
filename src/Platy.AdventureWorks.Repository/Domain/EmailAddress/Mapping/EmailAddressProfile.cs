using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="EmailAddress" /> .
/// </summary>
public class EmailAddressProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmailAddressProfile" /> class.
  /// </summary>
  public EmailAddressProfile()
  {
    CreateMap<EmailAddress, EmailAddressReadModel>();

    CreateMap<EmailAddressCreateModel, EmailAddress>();

    CreateMap<EmailAddress, EmailAddressCreateModel>();

    CreateMap<EmailAddress, EmailAddressUpdateModel>();

    CreateMap<EmailAddressUpdateModel, EmailAddress>();

    CreateMap<EmailAddressReadModel, EmailAddressUpdateModel>();
  }
}
