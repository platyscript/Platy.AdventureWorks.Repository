using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductCategoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductCategoryCreateModel>>]
public partial class ProductCategoryCreateModelValidator
    : AbstractValidator<ProductCategoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCategoryCreateModelValidator"/> class.
    /// </summary>
    public ProductCategoryCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
