using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesReasonUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesReasonUpdateModel>>]
public class SalesReasonUpdateModelValidator
  : AbstractValidator<SalesReasonUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesReasonUpdateModelValidator" /> class.
  /// </summary>
  public SalesReasonUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.ReasonType).NotEmpty();
    RuleFor(p => p.ReasonType).MaximumLength(50);

    #endregion
  }
}
