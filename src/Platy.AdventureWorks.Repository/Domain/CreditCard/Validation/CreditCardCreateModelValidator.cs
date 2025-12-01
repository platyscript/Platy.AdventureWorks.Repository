using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CreditCardCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CreditCardCreateModel>>]
public partial class CreditCardCreateModelValidator
    : AbstractValidator<CreditCardCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardCreateModelValidator"/> class.
    /// </summary>
    public CreditCardCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CardType).NotEmpty();
        RuleFor(p => p.CardType).MaximumLength(50);
        RuleFor(p => p.CardNumber).NotEmpty();
        RuleFor(p => p.CardNumber).MaximumLength(25);
        #endregion
    }

}
