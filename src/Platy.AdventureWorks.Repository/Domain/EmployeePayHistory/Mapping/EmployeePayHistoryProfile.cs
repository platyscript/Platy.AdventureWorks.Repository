using System;

using AutoMapper;

using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmployeePayHistory"/> .
/// </summary>
public partial class EmployeePayHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePayHistoryProfile"/> class.
    /// </summary>
    public EmployeePayHistoryProfile()
    {
        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory, Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryReadModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryCreateModel, Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory, Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryCreateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory, Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryUpdateModel>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryUpdateModel, Platy.AdventureWorks.Repository.Data.Entities.EmployeePayHistory>();

        CreateMap<Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryReadModel, Platy.AdventureWorks.Repository.Domain.Models.EmployeePayHistoryUpdateModel>();

    }

}
