using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'Culture'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("Culture", Schema = "Production")]
public partial class Culture
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Culture"/> class.
    /// </summary>
    public Culture()
    {
        #region Generated Constructor
        ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'CultureID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CultureID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CultureID", TypeName = "nchar(6)")]
    public string Id { get; set; } = null!;

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
    /// Gets or sets the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
    /// </value>
    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    #endregion

}
