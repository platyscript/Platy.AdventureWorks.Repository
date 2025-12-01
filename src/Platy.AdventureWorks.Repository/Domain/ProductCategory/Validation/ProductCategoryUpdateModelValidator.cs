using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductCategoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductCategoryUpdateModel>>]
public partial class ProductCategoryUpdateModelValidator
    : AbstractValidator<ProductCategoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCategoryUpdateModelValidator"/> class.
    /// </summary>
    public ProductCategoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
