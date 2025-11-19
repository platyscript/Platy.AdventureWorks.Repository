using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="EmployeePayHistoryCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<EmployeePayHistoryCreateModel>>]
public class EmployeePayHistoryCreateModelValidator
  : AbstractValidator<EmployeePayHistoryCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmployeePayHistoryCreateModelValidator" /> class.
  /// </summary>
  public EmployeePayHistoryCreateModelValidator()
  {
  }
}
