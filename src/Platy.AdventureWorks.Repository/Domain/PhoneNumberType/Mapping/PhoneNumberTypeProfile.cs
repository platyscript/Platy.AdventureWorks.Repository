using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="PhoneNumberType" /> .
/// </summary>
public class PhoneNumberTypeProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PhoneNumberTypeProfile" /> class.
  /// </summary>
  public PhoneNumberTypeProfile()
  {
    CreateMap<PhoneNumberType, PhoneNumberTypeReadModel>();

    CreateMap<PhoneNumberTypeCreateModel, PhoneNumberType>();

    CreateMap<PhoneNumberType, PhoneNumberTypeCreateModel>();

    CreateMap<PhoneNumberType, PhoneNumberTypeUpdateModel>();

    CreateMap<PhoneNumberTypeUpdateModel, PhoneNumberType>();

    CreateMap<PhoneNumberTypeReadModel, PhoneNumberTypeUpdateModel>();
  }
}
