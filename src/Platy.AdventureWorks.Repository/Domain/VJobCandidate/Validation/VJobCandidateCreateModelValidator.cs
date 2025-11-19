using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VJobCandidateCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VJobCandidateCreateModel>>]
public class VJobCandidateCreateModelValidator
  : AbstractValidator<VJobCandidateCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateCreateModelValidator" /> class.
  /// </summary>
  public VJobCandidateCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.NamePrefix).MaximumLength(30);
    RuleFor(p => p.NameFirst).MaximumLength(30);
    RuleFor(p => p.NameMiddle).MaximumLength(30);
    RuleFor(p => p.NameLast).MaximumLength(30);
    RuleFor(p => p.NameSuffix).MaximumLength(30);
    RuleFor(p => p.AddrType).MaximumLength(30);
    RuleFor(p => p.AddrLocCountryRegion).MaximumLength(100);
    RuleFor(p => p.AddrLocState).MaximumLength(100);
    RuleFor(p => p.AddrLocCity).MaximumLength(100);
    RuleFor(p => p.AddrPostalCode).MaximumLength(20);

    #endregion
  }
}
