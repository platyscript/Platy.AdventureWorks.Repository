using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PersonPhoneUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PersonPhoneUpdateModel>>]
public class PersonPhoneUpdateModelValidator
  : AbstractValidator<PersonPhoneUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonPhoneUpdateModelValidator" /> class.
  /// </summary>
  public PersonPhoneUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.PhoneNumber).NotEmpty();
    RuleFor(p => p.PhoneNumber).MaximumLength(25);

    #endregion
  }
}
