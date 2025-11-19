using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesReasonCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesReasonCreateModel>>]
public class SalesReasonCreateModelValidator
  : AbstractValidator<SalesReasonCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesReasonCreateModelValidator" /> class.
  /// </summary>
  public SalesReasonCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.ReasonType).NotEmpty();
    RuleFor(p => p.ReasonType).MaximumLength(50);

    #endregion
  }
}
