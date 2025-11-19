using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VVendorWithContactsUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VVendorWithContactsUpdateModel>>]
public class VVendorWithContactsUpdateModelValidator
  : AbstractValidator<VVendorWithContactsUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VVendorWithContactsUpdateModelValidator" /> class.
  /// </summary>
  public VVendorWithContactsUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.ContactType).NotEmpty();
    RuleFor(p => p.ContactType).MaximumLength(50);
    RuleFor(p => p.Title).MaximumLength(8);
    RuleFor(p => p.FirstName).NotEmpty();
    RuleFor(p => p.FirstName).MaximumLength(50);
    RuleFor(p => p.MiddleName).MaximumLength(50);
    RuleFor(p => p.LastName).NotEmpty();
    RuleFor(p => p.LastName).MaximumLength(50);
    RuleFor(p => p.Suffix).MaximumLength(10);
    RuleFor(p => p.PhoneNumber).MaximumLength(25);
    RuleFor(p => p.PhoneNumberType).MaximumLength(50);
    RuleFor(p => p.EmailAddress).MaximumLength(50);

    #endregion
  }
}
