using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Employee" /> .
/// </summary>
public class EmployeeProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmployeeProfile" /> class.
  /// </summary>
  public EmployeeProfile()
  {
    CreateMap<Employee, EmployeeReadModel>();

    CreateMap<EmployeeCreateModel, Employee>();

    CreateMap<Employee, EmployeeCreateModel>();

    CreateMap<Employee, EmployeeUpdateModel>();

    CreateMap<EmployeeUpdateModel, Employee>();

    CreateMap<EmployeeReadModel, EmployeeUpdateModel>();
  }
}
