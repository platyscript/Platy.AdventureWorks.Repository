using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'Illustration'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("Illustration", Schema = "Production")]
public partial class Illustration
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Illustration"/> class.
    /// </summary>
    public Illustration()
    {
        #region Generated Constructor
        ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'IllustrationID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'IllustrationID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("IllustrationID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Diagram'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Diagram'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Diagram", TypeName = "xml")]
    public string? Diagram { get; set; }

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

    #endregion

}
