using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="EmailAddressUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<EmailAddressUpdateModel>>]
public class EmailAddressUpdateModelValidator
  : AbstractValidator<EmailAddressUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="EmailAddressUpdateModelValidator" /> class.
  /// </summary>
  public EmailAddressUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.EmailAddressMember).MaximumLength(50);

    #endregion
  }
}
