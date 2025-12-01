using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductDocument"/> .
/// </summary>
public partial class ProductDocumentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDocumentProfile"/> class.
    /// </summary>
    public ProductDocumentProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductDocument, Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductDocument>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductDocument, Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductDocument, Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductDocument>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductDocumentUpdateModel>();

    }

}
