using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Shift"/> .
/// </summary>
public partial class ShiftProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftProfile"/> class.
    /// </summary>
    public ShiftProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Shift, Platy.AdventureWorks.Repository.Domain.Models.ShiftReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShiftCreateModel, Platy.AdventureWorks.Repository.Data.Entities.Shift>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Shift, Platy.AdventureWorks.Repository.Domain.Models.ShiftCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.Shift, Platy.AdventureWorks.Repository.Domain.Models.ShiftUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShiftUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.Shift>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShiftReadModel, Platy.AdventureWorks.Repository.Domain.Models.ShiftUpdateModel>();

    }

}
