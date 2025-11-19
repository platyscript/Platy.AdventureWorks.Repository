using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
///   Entity class representing data for table 'TransactionHistoryArchive'.
/// </summary>
[Table("TransactionHistoryArchive", Schema = "Production")]
public class TransactionHistoryArchive
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="TransactionHistoryArchive" /> class.
  /// </summary>
  public TransactionHistoryArchive()
  {
  }

  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value representing column 'TransactionID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TransactionID'.
  /// </value>
  [Key]
  [Column("TransactionID", TypeName = "int")]
  public int TransactionId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ProductID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ProductID'.
  /// </value>
  [Column("ProductID", TypeName = "int")]
  public int ProductId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ReferenceOrderID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ReferenceOrderID'.
  /// </value>
  [Column("ReferenceOrderID", TypeName = "int")]
  public int ReferenceOrderId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ReferenceOrderLineID'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ReferenceOrderLineID'.
  /// </value>
  [Column("ReferenceOrderLineID", TypeName = "int")]
  public int ReferenceOrderLineId { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TransactionDate'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TransactionDate'.
  /// </value>
  [Column("TransactionDate", TypeName = "datetime")]
  public DateTime TransactionDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'TransactionType'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'TransactionType'.
  /// </value>
  [Column("TransactionType", TypeName = "nchar(1)")]
  public string TransactionType { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value representing column 'Quantity'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'Quantity'.
  /// </value>
  [Column("Quantity", TypeName = "int")]
  public int Quantity { get; set; }

  /// <summary>
  ///   Gets or sets the property value representing column 'ActualCost'.
  /// </summary>
  /// <value>
  ///   The property value representing column 'ActualCost'.
  /// </value>
  [Column("ActualCost", TypeName = "money")]
  public decimal ActualCost { get; set; }

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
