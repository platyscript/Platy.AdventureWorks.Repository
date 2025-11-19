using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'vProductModelCatalogDescription'.
/// </summary>
[Table("vProductModelCatalogDescription", Schema = "Production")]
public class VProductModelCatalogDescription
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VProductModelCatalogDescription" /> class.
  /// </summary>
  public VProductModelCatalogDescription()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductModelID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductModelID'.
  /// </value>
  [Column("ProductModelID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Summary'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Summary'.
  /// </value>
  [Column("Summary", TypeName = "nvarchar(max)")]
  public string? Summary { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Manufacturer'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Manufacturer'.
  /// </value>
  [Column("Manufacturer", TypeName = "nvarchar(max)")]
  public string? Manufacturer { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Copyright'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Copyright'.
  /// </value>
  [Column("Copyright", TypeName = "nvarchar(30)")]
  public string? Copyright { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductURL'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductURL'.
  /// </value>
  [Column("ProductURL", TypeName = "nvarchar(256)")]
  public string? ProductURL { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'WarrantyPeriod'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'WarrantyPeriod'.
  /// </value>
  [Column("WarrantyPeriod", TypeName = "nvarchar(256)")]
  public string? WarrantyPeriod { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'WarrantyDescription'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'WarrantyDescription'.
  /// </value>
  [Column("WarrantyDescription", TypeName = "nvarchar(256)")]
  public string? WarrantyDescription { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'NoOfYears'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'NoOfYears'.
  /// </value>
  [Column("NoOfYears", TypeName = "nvarchar(256)")]
  public string? NoOfYears { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'MaintenanceDescription'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MaintenanceDescription'.
  /// </value>
  [Column("MaintenanceDescription", TypeName = "nvarchar(256)")]
  public string? MaintenanceDescription { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Wheel'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Wheel'.
  /// </value>
  [Column("Wheel", TypeName = "nvarchar(256)")]
  public string? Wheel { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Saddle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Saddle'.
  /// </value>
  [Column("Saddle", TypeName = "nvarchar(256)")]
  public string? Saddle { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Pedal'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Pedal'.
  /// </value>
  [Column("Pedal", TypeName = "nvarchar(256)")]
  public string? Pedal { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'BikeFrame'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BikeFrame'.
  /// </value>
  [Column("BikeFrame", TypeName = "nvarchar(max)")]
  public string? BikeFrame { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Crankset'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Crankset'.
  /// </value>
  [Column("Crankset", TypeName = "nvarchar(256)")]
  public string? Crankset { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PictureAngle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PictureAngle'.
  /// </value>
  [Column("PictureAngle", TypeName = "nvarchar(256)")]
  public string? PictureAngle { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PictureSize'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PictureSize'.
  /// </value>
  [Column("PictureSize", TypeName = "nvarchar(256)")]
  public string? PictureSize { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductPhotoID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductPhotoID'.
  /// </value>
  [Column("ProductPhotoID", TypeName = "nvarchar(256)")]
  public string? ProductPhotoId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Material'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Material'.
  /// </value>
  [Column("Material", TypeName = "nvarchar(256)")]
  public string? Material { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Color'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Color'.
  /// </value>
  [Column("Color", TypeName = "nvarchar(256)")]
  public string? Color { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductLine'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductLine'.
  /// </value>
  [Column("ProductLine", TypeName = "nvarchar(256)")]
  public string? ProductLine { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Style'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Style'.
  /// </value>
  [Column("Style", TypeName = "nvarchar(256)")]
  public string? Style { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'RiderExperience'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'RiderExperience'.
  /// </value>
  [Column("RiderExperience", TypeName = "nvarchar(1024)")]
  public string? RiderExperience { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'rowguid'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'rowguid'.
  /// </value>
  [Column("rowguid", TypeName = "uniqueidentifier")]
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion
}
