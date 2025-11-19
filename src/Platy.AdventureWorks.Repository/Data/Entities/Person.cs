using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'Person'.
/// </summary>
[Table("Person", Schema = "Person")]
public class Person
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Person" /> class.
  /// </summary>
  public Person()
  {
    #region Generated Constructor

    BusinessEntityContacts = new HashSet<BusinessEntityContact>();
    Customers = new HashSet<Customer>();
    EmailAddresses = new HashSet<EmailAddress>();
    PersonCreditCards = new HashSet<PersonCreditCard>();
    PersonPhones = new HashSet<PersonPhone>();

    #endregion
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'BusinessEntityID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'BusinessEntityID'.
  /// </value>
  [Key]
  [Column("BusinessEntityID", TypeName = "int")]
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'PersonType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PersonType'.
  /// </value>
  [Column("PersonType", TypeName = "nchar(2)")]
  public string PersonType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'NameStyle'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'NameStyle'.
  /// </value>
  [Column("NameStyle", TypeName = "bit")]
  public bool NameStyle { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Title'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Title'.
  /// </value>
  [Column("Title", TypeName = "nvarchar(8)")]
  public string? Title { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'FirstName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'FirstName'.
  /// </value>
  [Column("FirstName", TypeName = "nvarchar(50)")]
  public string FirstName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'MiddleName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'MiddleName'.
  /// </value>
  [Column("MiddleName", TypeName = "nvarchar(50)")]
  public string? MiddleName { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'LastName'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'LastName'.
  /// </value>
  [Column("LastName", TypeName = "nvarchar(50)")]
  public string LastName { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Suffix'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Suffix'.
  /// </value>
  [Column("Suffix", TypeName = "nvarchar(10)")]
  public string? Suffix { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'EmailPromotion'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'EmailPromotion'.
  /// </value>
  [Column("EmailPromotion", TypeName = "int")]
  public int EmailPromotion { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'AdditionalContactInfo'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'AdditionalContactInfo'.
  /// </value>
  [Column("AdditionalContactInfo", TypeName = "xml")]
  public string? AdditionalContactInfo { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Demographics'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Demographics'.
  /// </value>
  [Column("Demographics", TypeName = "xml")]
  public string? Demographics { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'rowguid'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'rowguid'.
  /// </value>
  [Column("rowguid", TypeName = "uniqueidentifier")]
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="BusinessEntity" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual BusinessEntity BusinessEntity { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="BusinessEntityContact" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="BusinessEntityContact" />.
  /// </value>
  public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="Customer" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="Customer" />.
  /// </value>
  public virtual ICollection<Customer> Customers { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="EmailAddress" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="EmailAddress" />.
  /// </value>
  public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Employee" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Employee" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Employee Employee { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation property for entity <see cref="Password" />.
  /// </summary>
  /// <value>
  ///   The navigation property for entity <see cref="Password" />.
  /// </value>
  /// <seealso cref="BusinessEntityId" />
  public virtual Password Password { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="PersonCreditCard" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="PersonCreditCard" />.
  /// </value>
  public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="PersonPhone" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="PersonPhone" />.
  /// </value>
  public virtual ICollection<PersonPhone> PersonPhones { get; set; }

  #endregion
}
