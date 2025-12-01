using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="DepartmentUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<DepartmentUpdateModel>>]
public partial class DepartmentUpdateModelValidator
    : AbstractValidator<DepartmentUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepartmentUpdateModelValidator"/> class.
    /// </summary>
    public DepartmentUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.GroupName).NotEmpty();
        RuleFor(p => p.GroupName).MaximumLength(50);
        #endregion
    }

}
