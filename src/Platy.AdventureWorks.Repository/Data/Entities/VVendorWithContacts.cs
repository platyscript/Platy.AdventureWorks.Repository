using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vVendorWithContacts'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vVendorWithContacts", Schema = "Purchasing")]
public partial class VVendorWithContacts
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VVendorWithContacts"/> class.
    /// </summary>
    public VVendorWithContacts()
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
    /// Gets or sets the property value representing column 'ContactType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ContactType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ContactType", TypeName = "nvarchar(50)")]
    public string ContactType { get; set; } = null!;

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

    #endregion

    #region Generated Relationships
    #endregion

}
