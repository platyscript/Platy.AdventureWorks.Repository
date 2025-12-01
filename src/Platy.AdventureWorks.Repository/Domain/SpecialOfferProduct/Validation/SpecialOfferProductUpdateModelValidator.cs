using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SpecialOfferProductUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SpecialOfferProductUpdateModel>>]
public partial class SpecialOfferProductUpdateModelValidator
    : AbstractValidator<SpecialOfferProductUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProductUpdateModelValidator"/> class.
    /// </summary>
    public SpecialOfferProductUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
