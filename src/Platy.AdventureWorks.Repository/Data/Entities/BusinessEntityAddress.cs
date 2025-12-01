using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'BusinessEntityAddress'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("BusinessEntityAddress", Schema = "Person")]
public partial class BusinessEntityAddress
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityAddress"/> class.
    /// </summary>
    public BusinessEntityAddress()
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
    /// Gets or sets the property value representing column 'AddressID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressID", TypeName = "int")]
    public int AddressId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'AddressTypeID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressTypeID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressTypeID", TypeName = "int")]
    public int AddressTypeId { get; set; }

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
    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Address" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Address" />.
    /// </value>
    /// <seealso cref="AddressId" />
    public virtual Address Address { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="AddressType" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="AddressType" />.
    /// </value>
    /// <seealso cref="AddressTypeId" />
    public virtual AddressType AddressType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="BusinessEntity" />.
    /// </value>
    /// <seealso cref="BusinessEntityId" />
    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    #endregion

}
