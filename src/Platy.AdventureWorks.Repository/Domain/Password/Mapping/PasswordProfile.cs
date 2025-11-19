using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Password" /> .
/// </summary>
public class PasswordProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PasswordProfile" /> class.
  /// </summary>
  public PasswordProfile()
  {
    CreateMap<Password, PasswordReadModel>();

    CreateMap<PasswordCreateModel, Password>();

    CreateMap<Password, PasswordCreateModel>();

    CreateMap<Password, PasswordUpdateModel>();

    CreateMap<PasswordUpdateModel, Password>();

    CreateMap<PasswordReadModel, PasswordUpdateModel>();
  }
}
