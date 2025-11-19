using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VJobCandidateEducationUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VJobCandidateEducationUpdateModel>>]
public class VJobCandidateEducationUpdateModelValidator
  : AbstractValidator<VJobCandidateEducationUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateEducationUpdateModelValidator" /> class.
  /// </summary>
  public VJobCandidateEducationUpdateModelValidator()
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
