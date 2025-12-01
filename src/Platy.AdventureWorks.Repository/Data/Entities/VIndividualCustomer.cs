using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vIndividualCustomer'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vIndividualCustomer", Schema = "Sales")]
public partial class VIndividualCustomer
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VIndividualCustomer"/> class.
    /// </summary>
    public VIndividualCustomer()
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
    /// Gets or sets the property value representing column 'Title'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Title'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Title", TypeName = "nvarchar(8)")]
    public string? Title { get; set; }

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
    /// Gets or sets the property value representing column 'Suffix'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Suffix'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Suffix", TypeName = "nvarchar(10)")]
    public string? Suffix { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PhoneNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PhoneNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PhoneNumber", TypeName = "nvarchar(25)")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PhoneNumberType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PhoneNumberType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PhoneNumberType", TypeName = "nvarchar(50)")]
    public string? PhoneNumberType { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EmailAddress'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EmailAddress'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EmailAddress", TypeName = "nvarchar(50)")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EmailPromotion'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EmailPromotion'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EmailPromotion", TypeName = "int")]
    public int EmailPromotion { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'AddressType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressType", TypeName = "nvarchar(50)")]
    public string AddressType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AddressLine1'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressLine1'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressLine1", TypeName = "nvarchar(60)")]
    public string AddressLine1 { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AddressLine2'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressLine2'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressLine2", TypeName = "nvarchar(60)")]
    public string? AddressLine2 { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'City'.
    /// </summary>
    /// <value>
    /// The property value representing column 'City'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("City", TypeName = "nvarchar(30)")]
    public string City { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'StateProvinceName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StateProvinceName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StateProvinceName", TypeName = "nvarchar(50)")]
    public string StateProvinceName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'PostalCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PostalCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PostalCode", TypeName = "nvarchar(15)")]
    public string PostalCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'CountryRegionName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CountryRegionName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CountryRegionName", TypeName = "nvarchar(50)")]
    public string CountryRegionName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Demographics'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Demographics'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Demographics", TypeName = "xml")]
    public string? Demographics { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
