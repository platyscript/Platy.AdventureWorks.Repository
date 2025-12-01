using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTaxRate"/> .
/// </summary>
public partial class SalesTaxRateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTaxRateProfile"/> class.
    /// </summary>
    public SalesTaxRateProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate, Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateCreateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate, Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate, Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.SalesTaxRate>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateReadModel, Platy.AdventureWorks.Repository.Domain.Models.SalesTaxRateUpdateModel>();

    }

}
