using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Culture" /> .
/// </summary>
public class CultureProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="CultureProfile" /> class.
  /// </summary>
  public CultureProfile()
  {
    CreateMap<Culture, CultureReadModel>();

    CreateMap<CultureCreateModel, Culture>();

    CreateMap<Culture, CultureCreateModel>();

    CreateMap<Culture, CultureUpdateModel>();

    CreateMap<CultureUpdateModel, Culture>();

    CreateMap<CultureReadModel, CultureUpdateModel>();
  }
}
