using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CountryRegionCurrencyCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CountryRegionCurrencyCreateModel>>]
public partial class CountryRegionCurrencyCreateModelValidator
    : AbstractValidator<CountryRegionCurrencyCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionCurrencyCreateModelValidator"/> class.
    /// </summary>
    public CountryRegionCurrencyCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.CurrencyCode).NotEmpty();
        RuleFor(p => p.CurrencyCode).MaximumLength(3);
        #endregion
    }

}
