using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency" />
/// </summary>
internal class CountryRegionCurrencyConfiguration
  : IEntityTypeConfiguration<CountryRegionCurrency>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<CountryRegionCurrency> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("CountryRegionCurrency", "Sales");

    // key
    builder.HasKey(t => new { t.CountryRegionCode, t.CurrencyCode });

    // properties
    builder.Property(t => t.CountryRegionCode)
      .IsRequired()
      .HasColumnName("CountryRegionCode")
      .HasColumnType("nvarchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.CurrencyCode)
      .IsRequired()
      .HasColumnName("CurrencyCode")
      .HasColumnType("nchar(3)")
      .HasMaxLength(3);

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.CountryRegion)
      .WithMany(t => t.CountryRegionCurrencies)
      .HasForeignKey(d => d.CountryRegionCode)
      .HasConstraintName("FK_CountryRegionCurrency_CountryRegion_CountryRegionCode");

    builder.HasOne(t => t.Currency)
      .WithMany(t => t.CountryRegionCurrencies)
      .HasForeignKey(d => d.CurrencyCode)
      .HasConstraintName("FK_CountryRegionCurrency_Currency_CurrencyCode");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency" />
    /// </summary>
    public const string Name = "CountryRegionCurrency";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency.CountryRegionCode" />
    /// </summary>
    public const string CountryRegionCode = "CountryRegionCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency.CurrencyCode" />
    /// </summary>
    public const string CurrencyCode = "CurrencyCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.CountryRegionCurrency.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
