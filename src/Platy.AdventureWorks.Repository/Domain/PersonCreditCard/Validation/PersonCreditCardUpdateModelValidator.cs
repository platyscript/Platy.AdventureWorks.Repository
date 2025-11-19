using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PersonCreditCardUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PersonCreditCardUpdateModel>>]
public class PersonCreditCardUpdateModelValidator
  : AbstractValidator<PersonCreditCardUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonCreditCardUpdateModelValidator" /> class.
  /// </summary>
  public PersonCreditCardUpdateModelValidator()
  {
  }
}
