using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesPerson"/> .
/// </summary>
public partial class SalesPersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonProfile"/> class.
    /// </summary>
    public SalesPersonProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesPersonCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesPerson>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesPerson, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesPersonUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesPerson>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesPersonReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesPersonUpdateModel>();

    }

}
