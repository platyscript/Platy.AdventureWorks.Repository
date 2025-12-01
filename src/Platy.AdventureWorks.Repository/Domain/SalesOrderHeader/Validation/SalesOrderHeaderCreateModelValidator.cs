using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesOrderHeaderCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderHeaderCreateModel>>]
public partial class SalesOrderHeaderCreateModelValidator
    : AbstractValidator<SalesOrderHeaderCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderCreateModelValidator"/> class.
    /// </summary>
    public SalesOrderHeaderCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.PurchaseOrderNumber).MaximumLength(25);
        RuleFor(p => p.AccountNumber).MaximumLength(15);
        RuleFor(p => p.CreditCardApprovalCode).MaximumLength(15);
        RuleFor(p => p.Comment).MaximumLength(128);
        #endregion
    }

}
