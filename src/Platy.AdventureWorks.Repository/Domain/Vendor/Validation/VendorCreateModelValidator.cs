using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VendorCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VendorCreateModel>>]
public partial class VendorCreateModelValidator
    : AbstractValidator<VendorCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VendorCreateModelValidator"/> class.
    /// </summary>
    public VendorCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.AccountNumber).NotEmpty();
        RuleFor(p => p.AccountNumber).MaximumLength(15);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.PurchasingWebServiceURL).MaximumLength(1024);
        #endregion
    }

}
