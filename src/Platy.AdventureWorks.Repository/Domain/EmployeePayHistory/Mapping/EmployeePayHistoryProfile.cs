using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Mapping;

/// <summary>
///   Mapper class for entity <see cref="EmployeePayHistory" /> .
/// </summary>
public class EmployeePayHistoryProfile
  : Profile
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmployeePayHistoryProfile" /> class.
  /// </summary>
  public EmployeePayHistoryProfile()
  {
    CreateMap<EmployeePayHistory, EmployeePayHistoryReadModel>();

    CreateMap<EmployeePayHistoryCreateModel, EmployeePayHistory>();

    CreateMap<EmployeePayHistory, EmployeePayHistoryCreateModel>();

    CreateMap<EmployeePayHistory, EmployeePayHistoryUpdateModel>();

    CreateMap<EmployeePayHistoryUpdateModel, EmployeePayHistory>();

    CreateMap<EmployeePayHistoryReadModel, EmployeePayHistoryUpdateModel>();
  }
}
