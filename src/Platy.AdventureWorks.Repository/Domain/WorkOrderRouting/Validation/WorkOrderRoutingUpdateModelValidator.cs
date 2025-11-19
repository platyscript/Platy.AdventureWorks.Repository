using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="WorkOrderRoutingUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<WorkOrderRoutingUpdateModel>>]
public class WorkOrderRoutingUpdateModelValidator
  : AbstractValidator<WorkOrderRoutingUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="WorkOrderRoutingUpdateModelValidator" /> class.
  /// </summary>
  public WorkOrderRoutingUpdateModelValidator()
  {
  }
}
