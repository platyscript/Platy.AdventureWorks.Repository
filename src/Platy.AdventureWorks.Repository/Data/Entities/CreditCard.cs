using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'CreditCard'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("CreditCard", Schema = "Sales")]
public partial class CreditCard
    : HasDomainEventsBase, IIdentity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCard"/> class.
    /// </summary>
    public CreditCard()
    {
        #region Generated Constructor
        PersonCreditCards = new HashSet<PersonCreditCard>();
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'CreditCardID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CreditCardID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CreditCardID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'CardType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CardType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CardType", TypeName = "nvarchar(50)")]
    public string CardType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'CardNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CardNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CardNumber", TypeName = "nvarchar(25)")]
    public string CardNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ExpMonth'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ExpMonth'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ExpMonth", TypeName = "tinyint")]
    public byte ExpMonth { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ExpYear'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ExpYear'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ExpYear", TypeName = "smallint")]
    public short ExpYear { get; set; }

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
    /// Gets or sets the navigation collection for entity <see cref="PersonCreditCard" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="PersonCreditCard" />.
    /// </value>
    public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="SalesOrderHeader" />.
    /// </value>
    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    #endregion

}
