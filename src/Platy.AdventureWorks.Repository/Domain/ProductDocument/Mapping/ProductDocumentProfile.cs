using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="ProductDocument" /> .
/// </summary>
public class ProductDocumentProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductDocumentProfile" /> class.
  /// </summary>
  public ProductDocumentProfile()
  {
    CreateMap<ProductDocument, ProductDocumentReadModel>();

    CreateMap<ProductDocumentCreateModel, ProductDocument>();

    CreateMap<ProductDocument, ProductDocumentCreateModel>();

    CreateMap<ProductDocument, ProductDocumentUpdateModel>();

    CreateMap<ProductDocumentUpdateModel, ProductDocument>();

    CreateMap<ProductDocumentReadModel, ProductDocumentUpdateModel>();
  }
}
