using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VEmployee" /> .
/// </summary>
public class VEmployeeProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VEmployeeProfile" /> class.
  /// </summary>
  public VEmployeeProfile()
  {
    CreateMap<VEmployee, VEmployeeReadModel>();

    CreateMap<VEmployeeCreateModel, VEmployee>();

    CreateMap<VEmployee, VEmployeeCreateModel>();

    CreateMap<VEmployee, VEmployeeUpdateModel>();

    CreateMap<VEmployeeUpdateModel, VEmployee>();

    CreateMap<VEmployeeReadModel, VEmployeeUpdateModel>();
  }
}
