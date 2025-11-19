using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="LocationUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<LocationUpdateModel>>]
public class LocationUpdateModelValidator
  : AbstractValidator<LocationUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="LocationUpdateModelValidator" /> class.
  /// </summary>
  public LocationUpdateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);

    #endregion
  }
}
