namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class EmployeeDepartmentHistoryUpdateModel
  : IEntityUpdateModel
{
  #region Generated Properties

  /// <summary>
  ///   Gets or sets the property value for 'BusinessEntityId'.
  /// </summary>
  /// <value>
  ///   The property value for 'BusinessEntityId'.
  /// </value>
  public int BusinessEntityId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'DepartmentId'.
  /// </summary>
  /// <value>
  ///   The property value for 'DepartmentId'.
  /// </value>
  public short DepartmentId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ShiftId'.
  /// </summary>
  /// <value>
  ///   The property value for 'ShiftId'.
  /// </value>
  public byte ShiftId { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'StartDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'StartDate'.
  /// </value>
  public DateOnly StartDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'EndDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'EndDate'.
  /// </value>
  public DateOnly? EndDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
