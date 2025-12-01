using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'PersonPhone'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("PersonPhone", Schema = "Person")]
public partial class PersonPhone
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonPhone"/> class.
    /// </summary>
    public PersonPhone()
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
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PhoneNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PhoneNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("PhoneNumber", TypeName = "nvarchar(25)")]
    public string PhoneNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'PhoneNumberTypeID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PhoneNumberTypeID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("PhoneNumberTypeID", TypeName = "int")]
    public int PhoneNumberTypeId { get; set; }

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
    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Person" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Person" />.
    /// </value>
    /// <seealso cref="BusinessEntityId" />
    public virtual Person Person { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="PhoneNumberType" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="PhoneNumberType" />.
    /// </value>
    /// <seealso cref="PhoneNumberTypeId" />
    public virtual PhoneNumberType PhoneNumberType { get; set; } = null!;

    #endregion

}
