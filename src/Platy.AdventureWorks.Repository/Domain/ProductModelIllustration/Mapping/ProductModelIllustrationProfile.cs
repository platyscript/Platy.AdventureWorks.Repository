using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModelIllustration"/> .
/// </summary>
public partial class ProductModelIllustrationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelIllustrationProfile"/> class.
    /// </summary>
    public ProductModelIllustrationProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration, Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration, Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration, Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ProductModelIllustration>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationReadModel, Platy.AdventureWorks.Repository.Domain.Models.ProductModelIllustrationUpdateModel>();

    }

}
