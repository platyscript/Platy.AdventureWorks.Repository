using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductModelInstructions"/> .
/// </summary>
public partial class VProductModelInstructionsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelInstructionsProfile"/> class.
    /// </summary>
    public VProductModelInstructionsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions, Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions, Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions, Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VProductModelInstructions>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsReadModel, Platy.AdventureWorks.Repository.Domain.Models.VProductModelInstructionsUpdateModel>();

    }

}
