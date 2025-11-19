using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="SalesOrderHeaderUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderHeaderUpdateModel>>]
public class SalesOrderHeaderUpdateModelValidator
  : AbstractValidator<SalesOrderHeaderUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesOrderHeaderUpdateModelValidator" /> class.
  /// </summary>
  public SalesOrderHeaderUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.PurchaseOrderNumber).MaximumLength(25);
    RuleFor(p => p.AccountNumber).MaximumLength(15);
    RuleFor(p => p.CreditCardApprovalCode).MaximumLength(15);
    RuleFor(p => p.Comment).MaximumLength(128);

    #endregion
  }
}
