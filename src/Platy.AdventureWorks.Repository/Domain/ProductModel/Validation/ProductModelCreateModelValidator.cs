using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductModelCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelCreateModel>>]
public partial class ProductModelCreateModelValidator
    : AbstractValidator<ProductModelCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelCreateModelValidator"/> class.
    /// </summary>
    public ProductModelCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
