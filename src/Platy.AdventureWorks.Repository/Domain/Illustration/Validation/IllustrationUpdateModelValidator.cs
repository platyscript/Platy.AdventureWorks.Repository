using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="IllustrationUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<IllustrationUpdateModel>>]
public partial class IllustrationUpdateModelValidator
    : AbstractValidator<IllustrationUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IllustrationUpdateModelValidator"/> class.
    /// </summary>
    public IllustrationUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
