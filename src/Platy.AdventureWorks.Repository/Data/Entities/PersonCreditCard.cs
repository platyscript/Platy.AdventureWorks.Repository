using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'PersonCreditCard'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("PersonCreditCard", Schema = "Sales")]
public partial class PersonCreditCard
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonCreditCard"/> class.
    /// </summary>
    public PersonCreditCard()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessEntityID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'CreditCardID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CreditCardID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CreditCardID", TypeName = "int")]
    public int CreditCardId { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="CreditCard" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="CreditCard" />.
    /// </value>
    /// <seealso cref="CreditCardId" />
    public virtual CreditCard CreditCard { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Person" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Person" />.
    /// </value>
    /// <seealso cref="BusinessEntityId" />
    public virtual Person Person { get; set; } = null!;

    #endregion

}
