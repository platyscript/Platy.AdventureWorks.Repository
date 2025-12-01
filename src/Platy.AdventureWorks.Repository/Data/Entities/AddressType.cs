using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'AddressType'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("AddressType", Schema = "Person")]
public partial class AddressType
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressType"/> class.
    /// </summary>
    public AddressType()
    {
        #region Generated Constructor
        BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'AddressTypeID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressTypeID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressTypeID", TypeName = "int")]
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
    /// Gets or sets the navigation collection for entity <see cref="BusinessEntityAddress" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="BusinessEntityAddress" />.
    /// </value>
    public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    #endregion

}
