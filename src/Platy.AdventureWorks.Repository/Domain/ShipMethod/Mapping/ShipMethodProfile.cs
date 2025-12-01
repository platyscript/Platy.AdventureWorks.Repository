using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ShipMethod"/> .
/// </summary>
public partial class ShipMethodProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodProfile"/> class.
    /// </summary>
    public ShipMethodProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ShipMethod, Platy.AdventureWorks.Repository.Domain.Models.ShipMethodReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShipMethodCreateModel, Platy.AdventureWorks.Repository.Data.Entities.ShipMethod>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ShipMethod, Platy.AdventureWorks.Repository.Domain.Models.ShipMethodCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.ShipMethod, Platy.AdventureWorks.Repository.Domain.Models.ShipMethodUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShipMethodUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.ShipMethod>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.ShipMethodReadModel, Platy.AdventureWorks.Repository.Domain.Models.ShipMethodUpdateModel>();

    }

}
