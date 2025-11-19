using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure" />
/// </summary>
internal class UnitMeasureConfiguration
  : IEntityTypeConfiguration<UnitMeasure>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<UnitMeasure> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("UnitMeasure", "Production");

    // key
    builder.HasKey(t => t.UnitMeasureCode);

    // properties
    builder.Property(t => t.UnitMeasureCode)
      .IsRequired()
      .HasColumnName("UnitMeasureCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

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
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure" />
    /// </summary>
    public const string Name = "UnitMeasure";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure.UnitMeasureCode" />
    /// </summary>
    public const string UnitMeasureCode = "UnitMeasureCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.UnitMeasure.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
