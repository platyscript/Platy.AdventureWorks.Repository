using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CurrencyRateUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CurrencyRateUpdateModel>>]
public partial class CurrencyRateUpdateModelValidator
    : AbstractValidator<CurrencyRateUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRateUpdateModelValidator"/> class.
    /// </summary>
    public CurrencyRateUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.FromCurrencyCode).NotEmpty();
        RuleFor(p => p.FromCurrencyCode).MaximumLength(3);
        RuleFor(p => p.ToCurrencyCode).NotEmpty();
        RuleFor(p => p.ToCurrencyCode).MaximumLength(3);
        #endregion
    }

}
