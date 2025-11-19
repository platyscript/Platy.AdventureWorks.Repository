using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress" />
/// </summary>
internal class BusinessEntityAddressConfiguration
  : IEntityTypeConfiguration<BusinessEntityAddress>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<BusinessEntityAddress> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("BusinessEntityAddress", "Person");

    // key
    builder.HasKey(t => new { t.BusinessEntityId, t.AddressId, t.AddressTypeId });

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.AddressId)
      .IsRequired()
      .HasColumnName("AddressID")
      .HasColumnType("int");

    builder.Property(t => t.AddressTypeId)
      .IsRequired()
      .HasColumnName("AddressTypeID")
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
    builder.HasOne(t => t.Address)
      .WithMany(t => t.BusinessEntityAddresses)
      .HasForeignKey(d => d.AddressId)
      .HasConstraintName("FK_BusinessEntityAddress_Address_AddressID");

    builder.HasOne(t => t.AddressType)
      .WithMany(t => t.BusinessEntityAddresses)
      .HasForeignKey(d => d.AddressTypeId)
      .HasConstraintName("FK_BusinessEntityAddress_AddressType_AddressTypeID");

    builder.HasOne(t => t.BusinessEntity)
      .WithMany(t => t.BusinessEntityAddresses)
      .HasForeignKey(d => d.BusinessEntityId)
      .HasConstraintName("FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress" />
    /// </summary>
    public const string Schema = "Person";

    /// <summary>
    ///   Table Name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress" />
    /// </summary>
    public const string Name = "BusinessEntityAddress";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress.AddressId" />
    /// </summary>
    public const string AddressId = "AddressID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress.AddressTypeId" />
    /// </summary>
    public const string AddressTypeId = "AddressTypeID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.BusinessEntityAddress.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
