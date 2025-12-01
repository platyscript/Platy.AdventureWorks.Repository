using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductModelIllustrationUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelIllustrationUpdateModel>>]
public partial class ProductModelIllustrationUpdateModelValidator
    : AbstractValidator<ProductModelIllustrationUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelIllustrationUpdateModelValidator"/> class.
    /// </summary>
    public ProductModelIllustrationUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
