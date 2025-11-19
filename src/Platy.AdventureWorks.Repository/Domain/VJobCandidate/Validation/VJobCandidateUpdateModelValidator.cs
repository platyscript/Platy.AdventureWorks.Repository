using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VJobCandidateUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VJobCandidateUpdateModel>>]
public class VJobCandidateUpdateModelValidator
  : AbstractValidator<VJobCandidateUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateUpdateModelValidator" /> class.
  /// </summary>
  public VJobCandidateUpdateModelValidator()
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
