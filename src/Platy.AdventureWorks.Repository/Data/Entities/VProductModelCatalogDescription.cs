using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vProductModelCatalogDescription'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vProductModelCatalogDescription", Schema = "Production")]
public partial class VProductModelCatalogDescription
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelCatalogDescription"/> class.
    /// </summary>
    public VProductModelCatalogDescription()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ProductModelID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductModelID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductModelID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Summary'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Summary'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Summary", TypeName = "nvarchar(max)")]
    public string? Summary { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Manufacturer'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Manufacturer'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Manufacturer", TypeName = "nvarchar(max)")]
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Copyright'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Copyright'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Copyright", TypeName = "nvarchar(30)")]
    public string? Copyright { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductURL'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductURL'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductURL", TypeName = "nvarchar(256)")]
    public string? ProductURL { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'WarrantyPeriod'.
    /// </summary>
    /// <value>
    /// The property value representing column 'WarrantyPeriod'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("WarrantyPeriod", TypeName = "nvarchar(256)")]
    public string? WarrantyPeriod { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'WarrantyDescription'.
    /// </summary>
    /// <value>
    /// The property value representing column 'WarrantyDescription'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("WarrantyDescription", TypeName = "nvarchar(256)")]
    public string? WarrantyDescription { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'NoOfYears'.
    /// </summary>
    /// <value>
    /// The property value representing column 'NoOfYears'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("NoOfYears", TypeName = "nvarchar(256)")]
    public string? NoOfYears { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'MaintenanceDescription'.
    /// </summary>
    /// <value>
    /// The property value representing column 'MaintenanceDescription'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("MaintenanceDescription", TypeName = "nvarchar(256)")]
    public string? MaintenanceDescription { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Wheel'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Wheel'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Wheel", TypeName = "nvarchar(256)")]
    public string? Wheel { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Saddle'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Saddle'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Saddle", TypeName = "nvarchar(256)")]
    public string? Saddle { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Pedal'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Pedal'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Pedal", TypeName = "nvarchar(256)")]
    public string? Pedal { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'BikeFrame'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BikeFrame'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BikeFrame", TypeName = "nvarchar(max)")]
    public string? BikeFrame { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Crankset'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Crankset'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Crankset", TypeName = "nvarchar(256)")]
    public string? Crankset { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PictureAngle'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PictureAngle'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PictureAngle", TypeName = "nvarchar(256)")]
    public string? PictureAngle { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PictureSize'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PictureSize'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PictureSize", TypeName = "nvarchar(256)")]
    public string? PictureSize { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductPhotoID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductPhotoID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductPhotoID", TypeName = "nvarchar(256)")]
    public string? ProductPhotoId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Material'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Material'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Material", TypeName = "nvarchar(256)")]
    public string? Material { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Color'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Color'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Color", TypeName = "nvarchar(256)")]
    public string? Color { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductLine'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductLine'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductLine", TypeName = "nvarchar(256)")]
    public string? ProductLine { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Style'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Style'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Style", TypeName = "nvarchar(256)")]
    public string? Style { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'RiderExperience'.
    /// </summary>
    /// <value>
    /// The property value representing column 'RiderExperience'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("RiderExperience", TypeName = "nvarchar(1024)")]
    public string? RiderExperience { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'rowguid'.
    /// </summary>
    /// <value>
    /// The property value representing column 'rowguid'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("rowguid", TypeName = "uniqueidentifier")]
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ModifiedDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ModifiedDate", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
