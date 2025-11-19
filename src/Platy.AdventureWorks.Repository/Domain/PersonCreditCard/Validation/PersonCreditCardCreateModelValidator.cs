using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="PersonCreditCardCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<PersonCreditCardCreateModel>>]
public class PersonCreditCardCreateModelValidator
  : AbstractValidator<PersonCreditCardCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PersonCreditCardCreateModelValidator" /> class.
  /// </summary>
  public PersonCreditCardCreateModelValidator()
  {
  }
}
