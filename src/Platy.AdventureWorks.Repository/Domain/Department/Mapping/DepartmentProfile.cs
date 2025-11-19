using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="Department" /> .
/// </summary>
public class DepartmentProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="DepartmentProfile" /> class.
  /// </summary>
  public DepartmentProfile()
  {
    CreateMap<Department, DepartmentReadModel>();

    CreateMap<DepartmentCreateModel, Department>();

    CreateMap<Department, DepartmentCreateModel>();

    CreateMap<Department, DepartmentUpdateModel>();

    CreateMap<DepartmentUpdateModel, Department>();

    CreateMap<DepartmentReadModel, DepartmentUpdateModel>();
  }
}
