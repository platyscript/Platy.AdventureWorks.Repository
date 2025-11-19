using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses" />
/// </summary>
internal class VVendorWithAddressesConfiguration
  : IEntityTypeConfiguration<VVendorWithAddresses>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<VVendorWithAddresses> builder)
  {
    #region Generated Configure

    // table
    builder.ToView("vVendorWithAddresses", "Purchasing");

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

    builder.Property(t => t.AddressType)
      .IsRequired()
      .HasColumnName("AddressType")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.AddressLine1)
      .IsRequired()
      .HasColumnName("AddressLine1")
      .HasColumnType("nvarchar(60)")
      .HasMaxLength(60);

    builder.Property(t => t.AddressLine2)
      .HasColumnName("AddressLine2")
      .HasColumnType("nvarchar(60)")
      .HasMaxLength(60);

    builder.Property(t => t.City)
      .IsRequired()
      .HasColumnName("City")
      .HasColumnType("nvarchar(30)")
      .HasMaxLength(30);

    builder.Property(t => t.StateProvinceName)
      .IsRequired()
      .HasColumnName("StateProvinceName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.PostalCode)
      .IsRequired()
      .HasColumnName("PostalCode")
      .HasColumnType("nvarchar(15)")
      .HasMaxLength(15);

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
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses" />
    /// </summary>
    public const string Schema = "Purchasing";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses" />
    /// </summary>
    public const string Name = "vVendorWithAddresses";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.AddressType" />
    /// </summary>
    public const string AddressType = "AddressType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.AddressLine1" />
    /// </summary>
    public const string AddressLine1 = "AddressLine1";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.AddressLine2" />
    /// </summary>
    public const string AddressLine2 = "AddressLine2";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.City" />
    /// </summary>
    public const string City = "City";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.StateProvinceName" />
    /// </summary>
    public const string StateProvinceName = "StateProvinceName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.PostalCode" />
    /// </summary>
    public const string PostalCode = "PostalCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VVendorWithAddresses.CountryRegionName" />
    /// </summary>
    public const string CountryRegionName = "CountryRegionName";
  }

  #endregion
}
