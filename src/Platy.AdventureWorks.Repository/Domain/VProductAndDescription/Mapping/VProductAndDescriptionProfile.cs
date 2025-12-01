using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductAndDescription"/> .
/// </summary>
public partial class VProductAndDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductAndDescriptionProfile"/> class.
    /// </summary>
    public VProductAndDescriptionProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription, Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription, Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription, Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VProductAndDescription>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionReadModel, Platy.AdventureWorks.Repository.Domain.Models.VProductAndDescriptionUpdateModel>();

    }

}
