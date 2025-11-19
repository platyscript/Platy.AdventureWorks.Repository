using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="WorkOrderRoutingCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<WorkOrderRoutingCreateModel>>]
public class WorkOrderRoutingCreateModelValidator
  : AbstractValidator<WorkOrderRoutingCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="WorkOrderRoutingCreateModelValidator" /> class.
  /// </summary>
  public WorkOrderRoutingCreateModelValidator()
  {
  }
}
