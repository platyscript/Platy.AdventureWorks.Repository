using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesOrderDetailCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderDetailCreateModel>>]
public class SalesOrderDetailCreateModelValidator
  : AbstractValidator<SalesOrderDetailCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderDetailCreateModelValidator" /> class.
  /// </summary>
  public SalesOrderDetailCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.CarrierTrackingNumber).MaximumLength(25);

    #endregion
  }
}
