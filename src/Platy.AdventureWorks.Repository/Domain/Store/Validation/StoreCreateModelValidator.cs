using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="StoreCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<StoreCreateModel>>]
public class StoreCreateModelValidator
  : AbstractValidator<StoreCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="StoreCreateModelValidator" /> class.
  /// </summary>
  public StoreCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
