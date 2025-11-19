using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory" />
/// </summary>
internal class EmployeeDepartmentHistoryConfiguration
  : IEntityTypeConfiguration<EmployeeDepartmentHistory>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<EmployeeDepartmentHistory> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("EmployeeDepartmentHistory", "HumanResources");

    // key
    builder.HasKey(t => new { t.BusinessEntityId, t.DepartmentId, t.ShiftId, t.StartDate });

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.DepartmentId)
      .IsRequired()
      .HasColumnName("DepartmentID")
      .HasColumnType("smallint");

    builder.Property(t => t.ShiftId)
      .IsRequired()
      .HasColumnName("ShiftID")
      .HasColumnType("tinyint");

    builder.Property(t => t.StartDate)
      .IsRequired()
      .HasColumnName("StartDate")
      .HasColumnType("date");

    builder.Property(t => t.EndDate)
      .HasColumnName("EndDate")
      .HasColumnType("date");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.Department)
      .WithMany(t => t.EmployeeDepartmentHistories)
      .HasForeignKey(d => d.DepartmentId)
      .HasConstraintName("FK_EmployeeDepartmentHistory_Department_DepartmentID");

    builder.HasOne(t => t.Employee)
      .WithMany(t => t.EmployeeDepartmentHistories)
      .HasForeignKey(d => d.BusinessEntityId)
      .HasConstraintName("FK_EmployeeDepartmentHistory_Employee_BusinessEntityID");

    builder.HasOne(t => t.Shift)
      .WithMany(t => t.EmployeeDepartmentHistories)
      .HasForeignKey(d => d.ShiftId)
      .HasConstraintName("FK_EmployeeDepartmentHistory_Shift_ShiftID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory" />
    /// </summary>
    public const string Schema = "HumanResources";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory" />
    /// </summary>
    public const string Name = "EmployeeDepartmentHistory";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory.DepartmentId" />
    /// </summary>
    public const string DepartmentId = "DepartmentID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory.ShiftId" />
    /// </summary>
    public const string ShiftId = "ShiftID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory.StartDate" />
    /// </summary>
    public const string StartDate = "StartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory.EndDate" />
    /// </summary>
    public const string EndDate = "EndDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
