using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CurrencyCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CurrencyCreateModel>>]
public partial class CurrencyCreateModelValidator
    : AbstractValidator<CurrencyCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyCreateModelValidator"/> class.
    /// </summary>
    public CurrencyCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CurrencyCode).NotEmpty();
        RuleFor(p => p.CurrencyCode).MaximumLength(3);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
