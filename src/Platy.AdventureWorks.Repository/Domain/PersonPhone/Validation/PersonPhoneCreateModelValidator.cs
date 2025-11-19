using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PersonPhoneCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PersonPhoneCreateModel>>]
public class PersonPhoneCreateModelValidator
  : AbstractValidator<PersonPhoneCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonPhoneCreateModelValidator" /> class.
  /// </summary>
  public PersonPhoneCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.PhoneNumber).NotEmpty();
    RuleFor(p => p.PhoneNumber).MaximumLength(25);

    #endregion
  }
}
