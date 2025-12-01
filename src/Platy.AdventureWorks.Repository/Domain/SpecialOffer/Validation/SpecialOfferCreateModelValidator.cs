using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SpecialOfferCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SpecialOfferCreateModel>>]
public partial class SpecialOfferCreateModelValidator
    : AbstractValidator<SpecialOfferCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferCreateModelValidator"/> class.
    /// </summary>
    public SpecialOfferCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Description).NotEmpty();
        RuleFor(p => p.Description).MaximumLength(255);
        RuleFor(p => p.Type).NotEmpty();
        RuleFor(p => p.Type).MaximumLength(50);
        RuleFor(p => p.Category).NotEmpty();
        RuleFor(p => p.Category).MaximumLength(50);
        #endregion
    }

}
