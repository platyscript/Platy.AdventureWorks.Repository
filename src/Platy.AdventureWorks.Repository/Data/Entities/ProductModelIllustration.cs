using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ProductModelIllustration'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ProductModelIllustration", Schema = "Production")]
public partial class ProductModelIllustration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelIllustration"/> class.
    /// </summary>
    public ProductModelIllustration()
    {
        #region Generated Constructor
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
    public int ProductModelId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'IllustrationID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'IllustrationID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("IllustrationID", TypeName = "int")]
    public int IllustrationId { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Illustration" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Illustration" />.
    /// </value>
    /// <seealso cref="IllustrationId" />
    public virtual Illustration Illustration { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="ProductModel" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="ProductModel" />.
    /// </value>
    /// <seealso cref="ProductModelId" />
    public virtual ProductModel ProductModel { get; set; } = null!;

    #endregion

}
