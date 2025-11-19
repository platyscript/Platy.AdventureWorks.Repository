using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
///   Validator class for <see cref="VProductModelCatalogDescriptionCreateModel" /> .
/// </summary>
[RegisterSingleton<IValidator<VProductModelCatalogDescriptionCreateModel>>]
public class VProductModelCatalogDescriptionCreateModelValidator
  : AbstractValidator<VProductModelCatalogDescriptionCreateModel>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelCatalogDescriptionCreateModelValidator" /> class.
  /// </summary>
  public VProductModelCatalogDescriptionCreateModelValidator()
  {
    #region Generated Constructor

    RuleFor(p => p.Name).NotEmpty();
    RuleFor(p => p.Name).MaximumLength(50);
    RuleFor(p => p.Copyright).MaximumLength(30);
    RuleFor(p => p.ProductURL).MaximumLength(256);
    RuleFor(p => p.WarrantyPeriod).MaximumLength(256);
    RuleFor(p => p.WarrantyDescription).MaximumLength(256);
    RuleFor(p => p.NoOfYears).MaximumLength(256);
    RuleFor(p => p.MaintenanceDescription).MaximumLength(256);
    RuleFor(p => p.Wheel).MaximumLength(256);
    RuleFor(p => p.Saddle).MaximumLength(256);
    RuleFor(p => p.Pedal).MaximumLength(256);
    RuleFor(p => p.Crankset).MaximumLength(256);
    RuleFor(p => p.PictureAngle).MaximumLength(256);
    RuleFor(p => p.PictureSize).MaximumLength(256);
    RuleFor(p => p.ProductPhotoId).MaximumLength(256);
    RuleFor(p => p.Material).MaximumLength(256);
    RuleFor(p => p.Color).MaximumLength(256);
    RuleFor(p => p.ProductLine).MaximumLength(256);
    RuleFor(p => p.Style).MaximumLength(256);
    RuleFor(p => p.RiderExperience).MaximumLength(1024);

    #endregion
  }
}
