using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="EmployeeDepartmentHistory" /> .
/// </summary>
public class EmployeeDepartmentHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmployeeDepartmentHistoryProfile" /> class.
  /// </summary>
  public EmployeeDepartmentHistoryProfile()
  {
    CreateMap<EmployeeDepartmentHistory, EmployeeDepartmentHistoryReadModel>();

    CreateMap<EmployeeDepartmentHistoryCreateModel, EmployeeDepartmentHistory>();

    CreateMap<EmployeeDepartmentHistory, EmployeeDepartmentHistoryCreateModel>();

    CreateMap<EmployeeDepartmentHistory, EmployeeDepartmentHistoryUpdateModel>();

    CreateMap<EmployeeDepartmentHistoryUpdateModel, EmployeeDepartmentHistory>();

    CreateMap<EmployeeDepartmentHistoryReadModel, EmployeeDepartmentHistoryUpdateModel>();
  }
}
