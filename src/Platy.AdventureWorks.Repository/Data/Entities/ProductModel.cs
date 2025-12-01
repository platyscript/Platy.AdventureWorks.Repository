using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ProductModel'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ProductModel", Schema = "Production")]
public partial class ProductModel
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModel"/> class.
    /// </summary>
    public ProductModel()
    {
        #region Generated Constructor
        ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        Products = new HashSet<Product>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ProductModelID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductModelID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductModelID", TypeName = "int")]
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
    /// Gets or sets the property value representing column 'CatalogDescription'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CatalogDescription'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CatalogDescription", TypeName = "xml")]
    public string? CatalogDescription { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Instructions'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Instructions'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Instructions", TypeName = "xml")]
    public string? Instructions { get; set; }

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
    /// Gets or sets the navigation collection for entity <see cref="ProductModelIllustration" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="ProductModelIllustration" />.
    /// </value>
    public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
    /// </value>
    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="Product" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="Product" />.
    /// </value>
    public virtual ICollection<Product> Products { get; set; }

    #endregion

}
