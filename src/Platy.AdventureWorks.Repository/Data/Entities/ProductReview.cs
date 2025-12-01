using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ProductReview'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ProductReview", Schema = "Production")]
public partial class ProductReview
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReview"/> class.
    /// </summary>
    public ProductReview()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ProductReviewID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductReviewID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductReviewID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ReviewerName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ReviewerName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ReviewerName", TypeName = "nvarchar(50)")]
    public string ReviewerName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ReviewDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ReviewDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ReviewDate", TypeName = "datetime")]
    public DateTime ReviewDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EmailAddress'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EmailAddress'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EmailAddress", TypeName = "nvarchar(50)")]
    public string EmailAddress { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Rating'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Rating'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Rating", TypeName = "int")]
    public int Rating { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Comments'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Comments'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Comments", TypeName = "nvarchar(3850)")]
    public string? Comments { get; set; }

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
