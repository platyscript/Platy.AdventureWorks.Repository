using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vPersonDemographics'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vPersonDemographics", Schema = "Sales")]
public partial class VPersonDemographics
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VPersonDemographics"/> class.
    /// </summary>
    public VPersonDemographics()
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
    /// Gets or sets the property value representing column 'TotalPurchaseYTD'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TotalPurchaseYTD'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TotalPurchaseYTD", TypeName = "money")]
    public decimal? TotalPurchaseYTD { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'DateFirstPurchase'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DateFirstPurchase'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("DateFirstPurchase", TypeName = "datetime")]
    public DateTime? DateFirstPurchase { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'BirthDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BirthDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BirthDate", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'MaritalStatus'.
    /// </summary>
    /// <value>
    /// The property value representing column 'MaritalStatus'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("MaritalStatus", TypeName = "nvarchar(1)")]
    public string? MaritalStatus { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'YearlyIncome'.
    /// </summary>
    /// <value>
    /// The property value representing column 'YearlyIncome'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("YearlyIncome", TypeName = "nvarchar(30)")]
    public string? YearlyIncome { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Gender'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Gender'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Gender", TypeName = "nvarchar(1)")]
    public string? Gender { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TotalChildren'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TotalChildren'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TotalChildren", TypeName = "int")]
    public int? TotalChildren { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'NumberChildrenAtHome'.
    /// </summary>
    /// <value>
    /// The property value representing column 'NumberChildrenAtHome'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("NumberChildrenAtHome", TypeName = "int")]
    public int? NumberChildrenAtHome { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Education'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Education'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Education", TypeName = "nvarchar(30)")]
    public string? Education { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Occupation'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Occupation'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Occupation", TypeName = "nvarchar(30)")]
    public string? Occupation { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'HomeOwnerFlag'.
    /// </summary>
    /// <value>
    /// The property value representing column 'HomeOwnerFlag'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("HomeOwnerFlag", TypeName = "bit")]
    public bool? HomeOwnerFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'NumberCarsOwned'.
    /// </summary>
    /// <value>
    /// The property value representing column 'NumberCarsOwned'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("NumberCarsOwned", TypeName = "int")]
    public int? NumberCarsOwned { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
