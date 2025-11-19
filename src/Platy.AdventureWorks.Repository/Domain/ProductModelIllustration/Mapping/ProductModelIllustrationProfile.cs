using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductModelIllustration" /> .
/// </summary>
public class ProductModelIllustrationProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductModelIllustrationProfile" /> class.
  /// </summary>
  public ProductModelIllustrationProfile()
  {
    CreateMap<ProductModelIllustration, ProductModelIllustrationReadModel>();

    CreateMap<ProductModelIllustrationCreateModel, ProductModelIllustration>();

    CreateMap<ProductModelIllustration, ProductModelIllustrationCreateModel>();

    CreateMap<ProductModelIllustration, ProductModelIllustrationUpdateModel>();

    CreateMap<ProductModelIllustrationUpdateModel, ProductModelIllustration>();

    CreateMap<ProductModelIllustrationReadModel, ProductModelIllustrationUpdateModel>();
  }
}
