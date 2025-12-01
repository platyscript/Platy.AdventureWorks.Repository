using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductInventoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductInventoryUpdateModel>>]
public partial class ProductInventoryUpdateModelValidator
    : AbstractValidator<ProductInventoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductInventoryUpdateModelValidator"/> class.
    /// </summary>
    public ProductInventoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Shelf).NotEmpty();
        RuleFor(p => p.Shelf).MaximumLength(10);
        #endregion
    }

}
