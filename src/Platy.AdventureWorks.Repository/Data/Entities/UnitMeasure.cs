using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'UnitMeasure'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("UnitMeasure", Schema = "Production")]
public partial class UnitMeasure
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitMeasure"/> class.
    /// </summary>
    public UnitMeasure()
    {
        #region Generated Constructor
        BillOfMaterials = new HashSet<BillOfMaterials>();
        ProductVendors = new HashSet<ProductVendor>();
        SizeProducts = new HashSet<Product>();
        WeightProducts = new HashSet<Product>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'UnitMeasureCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'UnitMeasureCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("UnitMeasureCode", TypeName = "nchar(3)")]
    public string UnitMeasureCode { get; set; } = null!;

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
    /// Gets or sets the navigation collection for entity <see cref="BillOfMaterials" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="BillOfMaterials" />.
    /// </value>
    public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="ProductVendor" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="ProductVendor" />.
    /// </value>
    public virtual ICollection<ProductVendor> ProductVendors { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="Product" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="Product" />.
    /// </value>
    public virtual ICollection<Product> SizeProducts { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="Product" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="Product" />.
    /// </value>
    public virtual ICollection<Product> WeightProducts { get; set; }

    #endregion

}
