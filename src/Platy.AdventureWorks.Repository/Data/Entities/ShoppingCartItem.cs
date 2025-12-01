using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ShoppingCartItem'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ShoppingCartItem", Schema = "Sales")]
public partial class ShoppingCartItem
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShoppingCartItem"/> class.
    /// </summary>
    public ShoppingCartItem()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ShoppingCartItemID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ShoppingCartItemID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ShoppingCartItemID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ShoppingCartID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ShoppingCartID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ShoppingCartID", TypeName = "nvarchar(50)")]
    public string ShoppingCartId { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Quantity'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Quantity'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Quantity", TypeName = "int")]
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'DateCreated'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DateCreated'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("DateCreated", TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

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
