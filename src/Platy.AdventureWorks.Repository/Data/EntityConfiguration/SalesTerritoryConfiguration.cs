using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory" />
/// </summary>
internal class SalesTerritoryConfiguration
  : IEntityTypeConfiguration<SalesTerritory>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<SalesTerritory> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("SalesTerritory", "Sales");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("TerritoryID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.CountryRegionCode)
      .IsRequired()
      .HasColumnName("CountryRegionCode")
      .HasColumnType("nvarchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.Group)
      .IsRequired()
      .HasColumnName("Group")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.SalesYTD)
      .IsRequired()
      .HasColumnName("SalesYTD")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.SalesLastYear)
      .IsRequired()
      .HasColumnName("SalesLastYear")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.CostYTD)
      .IsRequired()
      .HasColumnName("CostYTD")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.CostLastYear)
      .IsRequired()
      .HasColumnName("CostLastYear")
      .HasColumnType("money")
      .HasDefaultValueSql("((0.00))");

    builder.Property(t => t.Rowguid)
      .IsRequired()
      .HasColumnName("rowguid")
      .HasColumnType("uniqueidentifier")
      .HasDefaultValueSql("(newid())");

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.CountryRegion)
      .WithMany(t => t.SalesTerritories)
      .HasForeignKey(d => d.CountryRegionCode)
      .HasConstraintName("FK_SalesTerritory_CountryRegion_CountryRegionCode");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory" />
    /// </summary>
    public const string Name = "SalesTerritory";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.Id" />
    /// </summary>
    public const string Id = "TerritoryID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.CountryRegionCode" />
    /// </summary>
    public const string CountryRegionCode = "CountryRegionCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.Group" />
    /// </summary>
    public const string Group = "Group";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.SalesYTD" />
    /// </summary>
    public const string SalesYTD = "SalesYTD";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.SalesLastYear" />
    /// </summary>
    public const string SalesLastYear = "SalesLastYear";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.CostYTD" />
    /// </summary>
    public const string CostYTD = "CostYTD";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.CostLastYear" />
    /// </summary>
    public const string CostLastYear = "CostLastYear";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.SalesTerritory.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
