using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VProductModelInstructionsCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VProductModelInstructionsCreateModel>>]
public partial class VProductModelInstructionsCreateModelValidator
    : AbstractValidator<VProductModelInstructionsCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelInstructionsCreateModelValidator"/> class.
    /// </summary>
    public VProductModelInstructionsCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.Step).MaximumLength(1024);
        #endregion
    }

}
