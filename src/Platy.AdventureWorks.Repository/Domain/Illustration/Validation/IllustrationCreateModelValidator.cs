using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="IllustrationCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<IllustrationCreateModel>>]
public class IllustrationCreateModelValidator
  : AbstractValidator<IllustrationCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="IllustrationCreateModelValidator" /> class.
  /// </summary>
  public IllustrationCreateModelValidator()
  {
  }
}
