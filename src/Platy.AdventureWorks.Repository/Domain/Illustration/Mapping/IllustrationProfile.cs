using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Illustration" /> .
/// </summary>
public class IllustrationProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="IllustrationProfile" /> class.
  /// </summary>
  public IllustrationProfile()
  {
    CreateMap<Illustration, IllustrationReadModel>();

    CreateMap<IllustrationCreateModel, Illustration>();

    CreateMap<Illustration, IllustrationCreateModel>();

    CreateMap<Illustration, IllustrationUpdateModel>();

    CreateMap<IllustrationUpdateModel, Illustration>();

    CreateMap<IllustrationReadModel, IllustrationUpdateModel>();
  }
}
