using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductModelCatalogDescription"/> .
/// </summary>
public partial class VProductModelCatalogDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelCatalogDescriptionProfile"/> class.
    /// </summary>
    public VProductModelCatalogDescriptionProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionReadModel, Platy.AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionUpdateModel>();

    }

}
