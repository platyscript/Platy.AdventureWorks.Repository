using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vStoreWithDemographics'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vStoreWithDemographics", Schema = "Sales")]
public partial class VStoreWithDemographics
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithDemographics"/> class.
    /// </summary>
    public VStoreWithDemographics()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessEntityID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AnnualSales'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AnnualSales'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AnnualSales", TypeName = "money")]
    public decimal? AnnualSales { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'AnnualRevenue'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AnnualRevenue'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AnnualRevenue", TypeName = "money")]
    public decimal? AnnualRevenue { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'BankName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BankName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BankName", TypeName = "nvarchar(50)")]
    public string? BankName { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'BusinessType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessType", TypeName = "nvarchar(5)")]
    public string? BusinessType { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'YearOpened'.
    /// </summary>
    /// <value>
    /// The property value representing column 'YearOpened'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("YearOpened", TypeName = "int")]
    public int? YearOpened { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Specialty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Specialty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Specialty", TypeName = "nvarchar(50)")]
    public string? Specialty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'SquareFeet'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SquareFeet'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("SquareFeet", TypeName = "int")]
    public int? SquareFeet { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Brands'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Brands'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Brands", TypeName = "nvarchar(30)")]
    public string? Brands { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Internet'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Internet'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Internet", TypeName = "nvarchar(30)")]
    public string? Internet { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'NumberEmployees'.
    /// </summary>
    /// <value>
    /// The property value representing column 'NumberEmployees'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("NumberEmployees", TypeName = "int")]
    public int? NumberEmployees { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
