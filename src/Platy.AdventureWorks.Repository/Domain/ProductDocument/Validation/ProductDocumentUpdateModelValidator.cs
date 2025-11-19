using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="ProductDocumentUpdateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<ProductDocumentUpdateModel>>]
public class ProductDocumentUpdateModelValidator
  : AbstractValidator<ProductDocumentUpdateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ProductDocumentUpdateModelValidator" /> class.
  /// </summary>
  public ProductDocumentUpdateModelValidator()
  {
  }
}
