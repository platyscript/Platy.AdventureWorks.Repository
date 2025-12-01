using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductModelUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelUpdateModel>>]
public partial class ProductModelUpdateModelValidator
    : AbstractValidator<ProductModelUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelUpdateModelValidator"/> class.
    /// </summary>
    public ProductModelUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
