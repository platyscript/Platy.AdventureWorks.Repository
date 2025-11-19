namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
///   View Model class
/// </summary>
public class EmployeeReadModel
  : IEntityReadModel
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
  ///   Gets or sets the property value for 'NationalIdNumber'.
  /// </summary>
  /// <value>
  ///   The property value for 'NationalIdNumber'.
  /// </value>
  public string NationalIdNumber { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'LoginId'.
  /// </summary>
  /// <value>
  ///   The property value for 'LoginId'.
  /// </value>
  public string LoginId { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'OrganizationLevel'.
  /// </summary>
  /// <value>
  ///   The property value for 'OrganizationLevel'.
  /// </value>
  public short? OrganizationLevel { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'JobTitle'.
  /// </summary>
  /// <value>
  ///   The property value for 'JobTitle'.
  /// </value>
  public string JobTitle { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'BirthDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'BirthDate'.
  /// </value>
  public DateOnly BirthDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'MaritalStatus'.
  /// </summary>
  /// <value>
  ///   The property value for 'MaritalStatus'.
  /// </value>
  public string MaritalStatus { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'Gender'.
  /// </summary>
  /// <value>
  ///   The property value for 'Gender'.
  /// </value>
  public string Gender { get; set; } = null!;

  /// <summary>
  ///   Gets or sets the property value for 'HireDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'HireDate'.
  /// </value>
  public DateOnly HireDate { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SalariedFlag'.
  /// </summary>
  /// <value>
  ///   The property value for 'SalariedFlag'.
  /// </value>
  public bool SalariedFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'VacationHours'.
  /// </summary>
  /// <value>
  ///   The property value for 'VacationHours'.
  /// </value>
  public short VacationHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'SickLeaveHours'.
  /// </summary>
  /// <value>
  ///   The property value for 'SickLeaveHours'.
  /// </value>
  public short SickLeaveHours { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'CurrentFlag'.
  /// </summary>
  /// <value>
  ///   The property value for 'CurrentFlag'.
  /// </value>
  public bool CurrentFlag { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'Rowguid'.
  /// </summary>
  /// <value>
  ///   The property value for 'Rowguid'.
  /// </value>
  public Guid Rowguid { get; set; }

  /// <summary>
  ///   Gets or sets the property value for 'ModifiedDate'.
  /// </summary>
  /// <value>
  ///   The property value for 'ModifiedDate'.
  /// </value>
  public DateTime ModifiedDate { get; set; }

  #endregion
}
