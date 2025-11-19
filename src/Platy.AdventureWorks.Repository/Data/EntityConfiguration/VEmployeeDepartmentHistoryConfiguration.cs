using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory" />
/// </summary>
internal class VEmployeeDepartmentHistoryConfiguration
  : IEntityTypeConfiguration<VEmployeeDepartmentHistory>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<VEmployeeDepartmentHistory> builder)
  {
    #region Generated Configure

    // table
    builder.ToView("vEmployeeDepartmentHistory", "HumanResources");

    // key
    builder.HasNoKey();

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.Title)
      .HasColumnName("Title")
      .HasColumnType("nvarchar(8)")
      .HasMaxLength(8);

    builder.Property(t => t.FirstName)
      .IsRequired()
      .HasColumnName("FirstName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.MiddleName)
      .HasColumnName("MiddleName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.LastName)
      .IsRequired()
      .HasColumnName("LastName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Suffix)
      .HasColumnName("Suffix")
      .HasColumnType("nvarchar(10)")
      .HasMaxLength(10);

    builder.Property(t => t.Shift)
      .IsRequired()
      .HasColumnName("Shift")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Department)
      .IsRequired()
      .HasColumnName("Department")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.GroupName)
      .IsRequired()
      .HasColumnName("GroupName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.StartDate)
      .IsRequired()
      .HasColumnName("StartDate")
      .HasColumnType("date");

    builder.Property(t => t.EndDate)
      .HasColumnName("EndDate")
      .HasColumnType("date");

    // relationships

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory" />
    /// </summary>
    public const string Schema = "HumanResources";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory" />
    /// </summary>
    public const string Name = "vEmployeeDepartmentHistory";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.Title" />
    /// </summary>
    public const string Title = "Title";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.FirstName" />
    /// </summary>
    public const string FirstName = "FirstName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.MiddleName" />
    /// </summary>
    public const string MiddleName = "MiddleName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.LastName" />
    /// </summary>
    public const string LastName = "LastName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.Suffix" />
    /// </summary>
    public const string Suffix = "Suffix";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.Shift" />
    /// </summary>
    public const string Shift = "Shift";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.Department" />
    /// </summary>
    public const string Department = "Department";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.GroupName" />
    /// </summary>
    public const string GroupName = "GroupName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.StartDate" />
    /// </summary>
    public const string StartDate = "StartDate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory.EndDate" />
    /// </summary>
    public const string EndDate = "EndDate";
  }

  #endregion
}
