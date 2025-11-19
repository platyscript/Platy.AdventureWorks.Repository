using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="VEmployeeDepartmentHistory" /> .
/// </summary>
public class VEmployeeDepartmentHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VEmployeeDepartmentHistoryProfile" /> class.
  /// </summary>
  public VEmployeeDepartmentHistoryProfile()
  {
    CreateMap<VEmployeeDepartmentHistory, VEmployeeDepartmentHistoryReadModel>();

    CreateMap<VEmployeeDepartmentHistoryCreateModel, VEmployeeDepartmentHistory>();

    CreateMap<VEmployeeDepartmentHistory, VEmployeeDepartmentHistoryCreateModel>();

    CreateMap<VEmployeeDepartmentHistory, VEmployeeDepartmentHistoryUpdateModel>();

    CreateMap<VEmployeeDepartmentHistoryUpdateModel, VEmployeeDepartmentHistory>();

    CreateMap<VEmployeeDepartmentHistoryReadModel, VEmployeeDepartmentHistoryUpdateModel>();
  }
}
