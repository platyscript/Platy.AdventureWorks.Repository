using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ScrapReasonUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ScrapReasonUpdateModel>>]
public partial class ScrapReasonUpdateModelValidator
    : AbstractValidator<ScrapReasonUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrapReasonUpdateModelValidator"/> class.
    /// </summary>
    public ScrapReasonUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
