using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'SpecialOffer'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("SpecialOffer", Schema = "Sales")]
public partial class SpecialOffer
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOffer"/> class.
    /// </summary>
    public SpecialOffer()
    {
        #region Generated Constructor
        SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'SpecialOfferID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'SpecialOfferID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("SpecialOfferID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Description'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Description'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Description", TypeName = "nvarchar(255)")]
    public string Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'DiscountPct'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DiscountPct'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("DiscountPct", TypeName = "smallmoney")]
    public decimal DiscountPct { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Type'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Type'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Type", TypeName = "nvarchar(50)")]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Category'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Category'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Category", TypeName = "nvarchar(50)")]
    public string Category { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StartDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StartDate", TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EndDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EndDate", TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'MinQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'MinQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("MinQty", TypeName = "int")]
    public int MinQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'MaxQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'MaxQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("MaxQty", TypeName = "int")]
    public int? MaxQty { get; set; }

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
    /// Gets or sets the navigation collection for entity <see cref="SpecialOfferProduct" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="SpecialOfferProduct" />.
    /// </value>
    public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    #endregion

}
