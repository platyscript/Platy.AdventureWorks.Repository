using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductSubcategoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductSubcategoryUpdateModel>>]
public partial class ProductSubcategoryUpdateModelValidator
    : AbstractValidator<ProductSubcategoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductSubcategoryUpdateModelValidator"/> class.
    /// </summary>
    public ProductSubcategoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
