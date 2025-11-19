using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductReviewCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductReviewCreateModel>>]
public class ProductReviewCreateModelValidator
  : AbstractValidator<ProductReviewCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductReviewCreateModelValidator" /> class.
  /// </summary>
  public ProductReviewCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.ReviewerName).NotEmpty();
    RuleFor(p => p.ReviewerName).MaximumLength(50);
    RuleFor(p => p.EmailAddress).NotEmpty();
    RuleFor(p => p.EmailAddress).MaximumLength(50);
    RuleFor(p => p.Comments).MaximumLength(3850);

    #endregion
  }
}
