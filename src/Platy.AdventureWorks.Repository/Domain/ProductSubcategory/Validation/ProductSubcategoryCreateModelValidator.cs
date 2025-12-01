using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductSubcategoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductSubcategoryCreateModel>>]
public partial class ProductSubcategoryCreateModelValidator
    : AbstractValidator<ProductSubcategoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductSubcategoryCreateModelValidator"/> class.
    /// </summary>
    public ProductSubcategoryCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
