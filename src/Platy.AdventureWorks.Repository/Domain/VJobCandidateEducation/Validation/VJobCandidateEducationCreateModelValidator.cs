using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VJobCandidateEducationCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VJobCandidateEducationCreateModel>>]
public partial class VJobCandidateEducationCreateModelValidator
    : AbstractValidator<VJobCandidateEducationCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEducationCreateModelValidator"/> class.
    /// </summary>
    public VJobCandidateEducationCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.EduDegree).MaximumLength(50);
        RuleFor(p => p.EduMajor).MaximumLength(50);
        RuleFor(p => p.EduMinor).MaximumLength(50);
        RuleFor(p => p.EduGPA).MaximumLength(5);
        RuleFor(p => p.EduGPAScale).MaximumLength(5);
        RuleFor(p => p.EduSchool).MaximumLength(100);
        RuleFor(p => p.EduLocCountryRegion).MaximumLength(100);
        RuleFor(p => p.EduLocState).MaximumLength(100);
        RuleFor(p => p.EduLocCity).MaximumLength(100);
        #endregion
    }

}
