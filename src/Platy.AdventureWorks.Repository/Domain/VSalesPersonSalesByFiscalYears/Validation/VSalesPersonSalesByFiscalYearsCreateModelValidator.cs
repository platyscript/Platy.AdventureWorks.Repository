using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VSalesPersonSalesByFiscalYearsCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VSalesPersonSalesByFiscalYearsCreateModel>>]
public partial class VSalesPersonSalesByFiscalYearsCreateModelValidator
    : AbstractValidator<VSalesPersonSalesByFiscalYearsCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYearsCreateModelValidator"/> class.
    /// </summary>
    public VSalesPersonSalesByFiscalYearsCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.FullName).MaximumLength(152);
        RuleFor(p => p.JobTitle).NotEmpty();
        RuleFor(p => p.JobTitle).MaximumLength(50);
        RuleFor(p => p.SalesTerritory).NotEmpty();
        RuleFor(p => p.SalesTerritory).MaximumLength(50);
        #endregion
    }

}
