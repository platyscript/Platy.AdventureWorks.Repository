using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vAdditionalContactInfo'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vAdditionalContactInfo", Schema = "Person")]
public partial class VAdditionalContactInfo
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VAdditionalContactInfo"/> class.
    /// </summary>
    public VAdditionalContactInfo()
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
    /// Gets or sets the property value representing column 'FirstName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'FirstName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("FirstName", TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'MiddleName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'MiddleName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("MiddleName", TypeName = "nvarchar(50)")]
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'LastName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'LastName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("LastName", TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'TelephoneNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TelephoneNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TelephoneNumber", TypeName = "nvarchar(50)")]
    public string? TelephoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TelephoneSpecialInstructions'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TelephoneSpecialInstructions'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TelephoneSpecialInstructions", TypeName = "nvarchar(max)")]
    public string? TelephoneSpecialInstructions { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Street'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Street'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Street", TypeName = "nvarchar(50)")]
    public string? Street { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'City'.
    /// </summary>
    /// <value>
    /// The property value representing column 'City'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("City", TypeName = "nvarchar(50)")]
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StateProvince'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StateProvince'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StateProvince", TypeName = "nvarchar(50)")]
    public string? StateProvince { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PostalCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PostalCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PostalCode", TypeName = "nvarchar(50)")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'CountryRegion'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CountryRegion'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CountryRegion", TypeName = "nvarchar(50)")]
    public string? CountryRegion { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'HomeAddressSpecialInstructions'.
    /// </summary>
    /// <value>
    /// The property value representing column 'HomeAddressSpecialInstructions'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("HomeAddressSpecialInstructions", TypeName = "nvarchar(max)")]
    public string? HomeAddressSpecialInstructions { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EMailAddress'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EMailAddress'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EMailAddress", TypeName = "nvarchar(128)")]
    public string? EMailAddress { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EMailSpecialInstructions'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EMailSpecialInstructions'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EMailSpecialInstructions", TypeName = "nvarchar(max)")]
    public string? EMailSpecialInstructions { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EMailTelephoneNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EMailTelephoneNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EMailTelephoneNumber", TypeName = "nvarchar(50)")]
    public string? EMailTelephoneNumber { get; set; }

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
