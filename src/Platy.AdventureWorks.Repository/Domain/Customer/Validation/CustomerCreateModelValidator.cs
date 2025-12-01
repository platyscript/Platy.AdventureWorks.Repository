using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CustomerCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CustomerCreateModel>>]
public partial class CustomerCreateModelValidator
    : AbstractValidator<CustomerCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerCreateModelValidator"/> class.
    /// </summary>
    public CustomerCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
