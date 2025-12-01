using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductDescriptionCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductDescriptionCreateModel>>]
public partial class ProductDescriptionCreateModelValidator
    : AbstractValidator<ProductDescriptionCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDescriptionCreateModelValidator"/> class.
    /// </summary>
    public ProductDescriptionCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Description).NotEmpty();
        RuleFor(p => p.Description).MaximumLength(400);
        #endregion
    }

}
