using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VSalesPersonSalesByFiscalYears"/> .
/// </summary>
public partial class VSalesPersonSalesByFiscalYearsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYearsProfile"/> class.
    /// </summary>
    public VSalesPersonSalesByFiscalYearsProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsCreateModel, Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsReadModel, Platy.AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsUpdateModel>();

    }

}
