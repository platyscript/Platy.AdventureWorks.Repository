using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="UnitMeasure"/> .
/// </summary>
public partial class UnitMeasureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitMeasureProfile"/> class.
    /// </summary>
    public UnitMeasureProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure, Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureCreateModel, Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure, Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure, Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureReadModel, Platy.AdventureWorks.Repository.Domain.Models.UnitMeasureUpdateModel>();

    }

}
