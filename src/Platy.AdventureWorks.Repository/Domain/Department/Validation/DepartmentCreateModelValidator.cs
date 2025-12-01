using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="DepartmentCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<DepartmentCreateModel>>]
public partial class DepartmentCreateModelValidator
    : AbstractValidator<DepartmentCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepartmentCreateModelValidator"/> class.
    /// </summary>
    public DepartmentCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.GroupName).NotEmpty();
        RuleFor(p => p.GroupName).MaximumLength(50);
        #endregion
    }

}
