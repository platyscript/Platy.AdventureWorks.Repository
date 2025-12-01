using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vProductAndDescription'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vProductAndDescription", Schema = "Production")]
public partial class VProductAndDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductAndDescription"/> class.
    /// </summary>
    public VProductAndDescription()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ProductModel'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductModel'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductModel", TypeName = "nvarchar(50)")]
    public string ProductModel { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'CultureID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CultureID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CultureID", TypeName = "nchar(6)")]
    public string CultureId { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Description'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Description'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Description", TypeName = "nvarchar(400)")]
    public string Description { get; set; } = null!;

    #endregion

    #region Generated Relationships
    #endregion

}
