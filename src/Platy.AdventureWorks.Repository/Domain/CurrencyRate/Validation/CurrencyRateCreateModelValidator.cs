using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CurrencyRateCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CurrencyRateCreateModel>>]
public partial class CurrencyRateCreateModelValidator
    : AbstractValidator<CurrencyRateCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRateCreateModelValidator"/> class.
    /// </summary>
    public CurrencyRateCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.FromCurrencyCode).NotEmpty();
        RuleFor(p => p.FromCurrencyCode).MaximumLength(3);
        RuleFor(p => p.ToCurrencyCode).NotEmpty();
        RuleFor(p => p.ToCurrencyCode).MaximumLength(3);
        #endregion
    }

}
