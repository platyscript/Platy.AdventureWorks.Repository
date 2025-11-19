using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics" />
/// </summary>
internal class VStoreWithDemographicsConfiguration
  : IEntityTypeConfiguration<VStoreWithDemographics>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<VStoreWithDemographics> builder)
  {
    #region Generated Configure

    // table
    builder.ToView("vStoreWithDemographics", "Sales");

    // key
    builder.HasNoKey();

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.AnnualSales)
      .HasColumnName("AnnualSales")
      .HasColumnType("money");

    builder.Property(t => t.AnnualRevenue)
      .HasColumnName("AnnualRevenue")
      .HasColumnType("money");

    builder.Property(t => t.BankName)
      .HasColumnName("BankName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.BusinessType)
      .HasColumnName("BusinessType")
      .HasColumnType("nvarchar(5)")
      .HasMaxLength(5);

    builder.Property(t => t.YearOpened)
      .HasColumnName("YearOpened")
      .HasColumnType("int");

    builder.Property(t => t.Specialty)
      .HasColumnName("Specialty")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.SquareFeet)
      .HasColumnName("SquareFeet")
      .HasColumnType("int");

    builder.Property(t => t.Brands)
      .HasColumnName("Brands")
      .HasColumnType("nvarchar(30)")
      .HasMaxLength(30);

    builder.Property(t => t.Internet)
      .HasColumnName("Internet")
      .HasColumnType("nvarchar(30)")
      .HasMaxLength(30);

    builder.Property(t => t.NumberEmployees)
      .HasColumnName("NumberEmployees")
      .HasColumnType("int");

    // relationships

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics" />
    /// </summary>
    public const string Name = "vStoreWithDemographics";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.AnnualSales" />
    /// </summary>
    public const string AnnualSales = "AnnualSales";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.AnnualRevenue" />
    /// </summary>
    public const string AnnualRevenue = "AnnualRevenue";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.BankName" />
    /// </summary>
    public const string BankName = "BankName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.BusinessType" />
    /// </summary>
    public const string BusinessType = "BusinessType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.YearOpened" />
    /// </summary>
    public const string YearOpened = "YearOpened";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.Specialty" />
    /// </summary>
    public const string Specialty = "Specialty";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.SquareFeet" />
    /// </summary>
    public const string SquareFeet = "SquareFeet";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.Brands" />
    /// </summary>
    public const string Brands = "Brands";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.Internet" />
    /// </summary>
    public const string Internet = "Internet";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithDemographics.NumberEmployees" />
    /// </summary>
    public const string NumberEmployees = "NumberEmployees";
  }

  #endregion
}
