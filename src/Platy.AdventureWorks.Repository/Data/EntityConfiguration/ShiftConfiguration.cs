using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift" />
/// </summary>
internal class ShiftConfiguration
  : IEntityTypeConfiguration<Shift>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<Shift> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("Shift", "HumanResources");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("ShiftID")
      .HasColumnType("tinyint")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.StartTime)
      .IsRequired()
      .HasColumnName("StartTime")
      .HasColumnType("time");

    builder.Property(t => t.EndTime)
      .IsRequired()
      .HasColumnName("EndTime")
      .HasColumnType("time");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift" />
    /// </summary>
    public const string Schema = "HumanResources";

    /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift" /></summary>
    public const string Name = "Shift";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift.Id" />
    /// </summary>
    public const string Id = "ShiftID";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift.StartTime" />
    /// </summary>
    public const string StartTime = "StartTime";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift.EndTime" />
    /// </summary>
    public const string EndTime = "EndTime";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Shift.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
