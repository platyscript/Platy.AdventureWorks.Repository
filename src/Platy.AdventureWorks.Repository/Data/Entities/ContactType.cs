using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ContactType'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ContactType", Schema = "Person")]
public partial class ContactType
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactType"/> class.
    /// </summary>
    public ContactType()
    {
        #region Generated Constructor
        BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ContactTypeID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ContactTypeID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ContactTypeID", TypeName = "int")]
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
    /// Gets or sets the navigation collection for entity <see cref="BusinessEntityContact" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="BusinessEntityContact" />.
    /// </value>
    public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

    #endregion

}
