using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VEmployeeDepartment" /> .
/// </summary>
public class VEmployeeDepartmentProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VEmployeeDepartmentProfile" /> class.
  /// </summary>
  public VEmployeeDepartmentProfile()
  {
    CreateMap<VEmployeeDepartment, VEmployeeDepartmentReadModel>();

    CreateMap<VEmployeeDepartmentCreateModel, VEmployeeDepartment>();

    CreateMap<VEmployeeDepartment, VEmployeeDepartmentCreateModel>();

    CreateMap<VEmployeeDepartment, VEmployeeDepartmentUpdateModel>();

    CreateMap<VEmployeeDepartmentUpdateModel, VEmployeeDepartment>();

    CreateMap<VEmployeeDepartmentReadModel, VEmployeeDepartmentUpdateModel>();
  }
}
