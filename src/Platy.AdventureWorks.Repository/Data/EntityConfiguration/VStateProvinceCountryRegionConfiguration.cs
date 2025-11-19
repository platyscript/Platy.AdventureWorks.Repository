using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion" />
/// </summary>
internal class VStateProvinceCountryRegionConfiguration
  : IEntityTypeConfiguration<VStateProvinceCountryRegion>
{
  /// <summary>
  ///   Configures the entity of type
  ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<VStateProvinceCountryRegion> builder)
  {
    #region Generated Configure

    // table
    builder.ToView("vStateProvinceCountryRegion", "Person");

    // key
    builder.HasNoKey();

    // properties
    builder.Property(t => t.StateProvinceId)
      .IsRequired()
      .HasColumnName("StateProvinceID")
      .HasColumnType("int");

    builder.Property(t => t.StateProvinceCode)
      .IsRequired()
      .HasColumnName("StateProvinceCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.IsOnlyStateProvinceFlag)
      .IsRequired()
      .HasColumnName("IsOnlyStateProvinceFlag")
      .HasColumnType("bit");

    builder.Property(t => t.StateProvinceName)
      .IsRequired()
      .HasColumnName("StateProvinceName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.TerritoryId)
      .IsRequired()
      .HasColumnName("TerritoryID")
      .HasColumnType("int");

    builder.Property(t => t.CountryRegionCode)
      .IsRequired()
      .HasColumnName("CountryRegionCode")
      .HasColumnType("nvarchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.CountryRegionName)
      .IsRequired()
      .HasColumnName("CountryRegionName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    // relationships

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion" />
    /// </summary>
    public const string Schema = "Person";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion" />
    /// </summary>
    public const string Name = "vStateProvinceCountryRegion";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.StateProvinceId" />
    /// </summary>
    public const string StateProvinceId = "StateProvinceID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.StateProvinceCode" />
    /// </summary>
    public const string StateProvinceCode = "StateProvinceCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.IsOnlyStateProvinceFlag" />
    /// </summary>
    public const string IsOnlyStateProvinceFlag = "IsOnlyStateProvinceFlag";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.StateProvinceName" />
    /// </summary>
    public const string StateProvinceName = "StateProvinceName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.TerritoryId" />
    /// </summary>
    public const string TerritoryId = "TerritoryID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.CountryRegionCode" />
    /// </summary>
    public const string CountryRegionCode = "CountryRegionCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion.CountryRegionName" />
    /// </summary>
    public const string CountryRegionName = "CountryRegionName";
  }

  #endregion
}
