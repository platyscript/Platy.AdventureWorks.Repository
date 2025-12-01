using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ShipMethodCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ShipMethodCreateModel>>]
public partial class ShipMethodCreateModelValidator
    : AbstractValidator<ShipMethodCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodCreateModelValidator"/> class.
    /// </summary>
    public ShipMethodCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
