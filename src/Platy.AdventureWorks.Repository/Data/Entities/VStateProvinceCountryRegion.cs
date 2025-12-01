using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vStateProvinceCountryRegion'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vStateProvinceCountryRegion", Schema = "Person")]
public partial class VStateProvinceCountryRegion
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStateProvinceCountryRegion"/> class.
    /// </summary>
    public VStateProvinceCountryRegion()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'StateProvinceID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StateProvinceID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StateProvinceID", TypeName = "int")]
    public int StateProvinceId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StateProvinceCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StateProvinceCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StateProvinceCode", TypeName = "nchar(3)")]
    public string StateProvinceCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'IsOnlyStateProvinceFlag'.
    /// </summary>
    /// <value>
    /// The property value representing column 'IsOnlyStateProvinceFlag'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("IsOnlyStateProvinceFlag", TypeName = "bit")]
    public bool IsOnlyStateProvinceFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StateProvinceName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StateProvinceName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StateProvinceName", TypeName = "nvarchar(50)")]
    public string StateProvinceName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TerritoryID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TerritoryID", TypeName = "int")]
    public int TerritoryId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'CountryRegionCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CountryRegionCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CountryRegionCode", TypeName = "nvarchar(3)")]
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'CountryRegionName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CountryRegionName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CountryRegionName", TypeName = "nvarchar(50)")]
    public string CountryRegionName { get; set; } = null!;

    #endregion

    #region Generated Relationships
    #endregion

}
