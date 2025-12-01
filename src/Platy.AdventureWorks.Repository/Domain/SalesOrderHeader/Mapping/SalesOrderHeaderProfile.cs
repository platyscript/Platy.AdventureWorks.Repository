using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderHeader"/> .
/// </summary>
public partial class SalesOrderHeaderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderProfile"/> class.
    /// </summary>
    public SalesOrderHeaderProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesOrderHeader>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesOrderHeaderUpdateModel>();

    }

}
