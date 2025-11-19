using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location" />
/// </summary>
internal class LocationConfiguration
  : IEntityTypeConfiguration<Location>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<Location> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("Location", "Production");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("LocationID")
      .HasColumnType("smallint")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.CostRate)
      .IsRequired()
      .HasColumnName("CostRate")
      .HasColumnType("smallmoney")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.Availability)
      .IsRequired()
      .HasColumnName("Availability")
      .HasColumnType("decimal(8,2)")
      .HasDefaultValueSql("((0.00))");

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
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location" />
    /// </summary>
    public const string Schema = "Production";

    /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location" /></summary>
    public const string Name = "Location";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location.Id" />
    /// </summary>
    public const string Id = "LocationID";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location.CostRate" />
    /// </summary>
    public const string CostRate = "CostRate";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location.Availability" />
    /// </summary>
    public const string Availability = "Availability";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Location.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
