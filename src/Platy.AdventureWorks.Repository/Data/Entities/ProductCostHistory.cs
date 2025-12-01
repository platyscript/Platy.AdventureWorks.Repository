using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ProductCostHistory'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ProductCostHistory", Schema = "Production")]
public partial class ProductCostHistory
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCostHistory"/> class.
    /// </summary>
    public ProductCostHistory()
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
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StartDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("StartDate", TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EndDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EndDate", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StandardCost'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StandardCost'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StandardCost", TypeName = "money")]
    public decimal StandardCost { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Product" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Product" />.
    /// </value>
    /// <seealso cref="ProductId" />
    public virtual Product Product { get; set; } = null!;

    #endregion

}
