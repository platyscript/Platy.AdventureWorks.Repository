using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor" />
/// </summary>
internal class VendorConfiguration
  : IEntityTypeConfiguration<Vendor>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<Vendor> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("Vendor", "Purchasing");

    // key
    builder.HasKey(t => t.BusinessEntityId);

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.AccountNumber)
      .IsRequired()
      .HasColumnName("AccountNumber")
      .HasColumnType("nvarchar(15)")
      .HasMaxLength(15);

    builder.Property(t => t.Name)
      .IsRequired()
      .HasColumnName("Name")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.CreditRating)
      .IsRequired()
      .HasColumnName("CreditRating")
      .HasColumnType("tinyint");

    builder.Property(t => t.PreferredVendorStatus)
      .IsRequired()
      .HasColumnName("PreferredVendorStatus")
      .HasColumnType("bit")
      .HasDefaultValue(true);

    builder.Property(t => t.ActiveFlag)
      .IsRequired()
      .HasColumnName("ActiveFlag")
      .HasColumnType("bit")
      .HasDefaultValue(true);

    builder.Property(t => t.PurchasingWebServiceURL)
      .HasColumnName("PurchasingWebServiceURL")
      .HasColumnType("nvarchar(1024)")
      .HasMaxLength(1024);

    builder.Property(t => t.ModifiedDate)
      .IsRequired()
      .HasColumnName("ModifiedDate")
      .HasColumnType("datetime")
      .HasDefaultValueSql("(getdate())");

    // relationships
    builder.HasOne(t => t.BusinessEntity)
      .WithOne(t => t.Vendor)
      .HasForeignKey<Vendor>(d => d.BusinessEntityId)
      .HasConstraintName("FK_Vendor_BusinessEntity_BusinessEntityID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor" />
    /// </summary>
    public const string Schema = "Purchasing";

    /// <summary>Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor" /></summary>
    public const string Name = "Vendor";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.AccountNumber" />
    /// </summary>
    public const string AccountNumber = "AccountNumber";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.CreditRating" />
    /// </summary>
    public const string CreditRating = "CreditRating";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.PreferredVendorStatus" />
    /// </summary>
    public const string PreferredVendorStatus = "PreferredVendorStatus";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.ActiveFlag" />
    /// </summary>
    public const string ActiveFlag = "ActiveFlag";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.PurchasingWebServiceURL" />
    /// </summary>
    public const string PurchasingWebServiceURL = "PurchasingWebServiceURL";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.Vendor.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
