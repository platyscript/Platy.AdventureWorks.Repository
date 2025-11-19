using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'SalesReason'.
/// </summary>
[Table("SalesReason", Schema = "Sales")]
public class SalesReason
  : HasDomainEventsBase, IIdentity<int>
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="SalesReason" /> class.
  /// </summary>
  public SalesReason()
  {
    #region Generated Constructor

    SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

    #endregion
  }

  #region Generated Relationships

  /// <summary>
  ///   Gets or sets the navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
  /// </summary>
  /// <value>
  ///   The navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
  /// </value>
  public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

  #endregion

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'SalesReasonID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'SalesReasonID'.
  /// </value>
  [Key]
  [Column("SalesReasonID", TypeName = "int")]
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
  ///   Gets or sets the property value representing column 'ReasonType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ReasonType'.
  /// </value>
  [Column("ReasonType", TypeName = "nvarchar(50)")]
  public string ReasonType { get; set; } = null!;

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
