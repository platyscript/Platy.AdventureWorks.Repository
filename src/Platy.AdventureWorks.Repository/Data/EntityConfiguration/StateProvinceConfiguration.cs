using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince" />
/// </summary>
internal class StateProvinceConfiguration
  : IEntityTypeConfiguration<StateProvince>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<StateProvince> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("StateProvince", "Person");

    // key
    builder.HasKey(t => t.Id);

    // properties
    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("StateProvinceID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.StateProvinceCode)
      .IsRequired()
      .HasColumnName("StateProvinceCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.CountryRegionCode)
      .IsRequired()
      .HasColumnName("CountryRegionCode")
      .HasColumnType("nvarchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.IsOnlyStateProvinceFlag)
      .IsRequired()
      .HasColumnName("IsOnlyStateProvinceFlag")
      .HasColumnType("bit")
      .HasDefaultValue(true);

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.TerritoryId)
      .IsRequired()
      .HasColumnName("TerritoryID")
      .HasColumnType("int");

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
      .WithMany(t => t.StateProvinces)
      .HasForeignKey(d => d.CountryRegionCode)
      .HasConstraintName("FK_StateProvince_CountryRegion_CountryRegionCode");

    builder.HasOne(t => t.SalesTerritory)
      .WithMany(t => t.StateProvinces)
      .HasForeignKey(d => d.TerritoryId)
      .HasConstraintName("FK_StateProvince_SalesTerritory_TerritoryID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince" />
    /// </summary>
    public const string Schema = "Person";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince" />
    /// </summary>
    public const string Name = "StateProvince";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.Id" />
    /// </summary>
    public const string Id = "StateProvinceID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.StateProvinceCode" />
    /// </summary>
    public const string StateProvinceCode = "StateProvinceCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.CountryRegionCode" />
    /// </summary>
    public const string CountryRegionCode = "CountryRegionCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.IsOnlyStateProvinceFlag" />
    /// </summary>
    public const string IsOnlyStateProvinceFlag = "IsOnlyStateProvinceFlag";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.TerritoryId" />
    /// </summary>
    public const string TerritoryId = "TerritoryID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.StateProvince.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
