using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'PhoneNumberType'.
/// </summary>
[Table("PhoneNumberType", Schema = "Person")]
public class PhoneNumberType
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PhoneNumberType" /> class.
  /// </summary>
  public PhoneNumberType()
  {
    #region Generated Constructor

    PersonPhones = new HashSet<PersonPhone>();

    #endregion
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="PersonPhone" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="PersonPhone" />.
  /// </value>
  public virtual ICollection<PersonPhone> PersonPhones { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'PhoneNumberTypeID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'PhoneNumberTypeID'.
  /// </value>
  [Key]
  [Column("PhoneNumberTypeID", TypeName = "int")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'Name'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Name'.
  /// </value>
  [Column("Name", TypeName = "nvarchar(50)")]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ModifiedDate'.
  /// </value>
  [Column("ModifiedDate", TypeName = "datetime")]
  public DateTime ModifiedDate { get; set; }

  #endregion
}
