using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress" />
/// </summary>
internal class EmailAddressConfiguration
  : IEntityTypeConfiguration<EmailAddress>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<EmailAddress> builder)
  {
    #region Generated Configure

    // table
    builder.ToTable("EmailAddress", "Person");

    // key
    builder.HasKey(t => new { t.BusinessEntityId, t.Id });

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

    builder.Property(t => t.Id)
      .IsRequired()
      .HasColumnName("EmailAddressID")
      .HasColumnType("int")
      .ValueGeneratedOnAdd();

    builder.Property(t => t.EmailAddressMember)
      .HasColumnName("EmailAddress")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

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
    builder.HasOne(t => t.Person)
      .WithMany(t => t.EmailAddresses)
      .HasForeignKey(d => d.BusinessEntityId)
      .HasConstraintName("FK_EmailAddress_Person_BusinessEntityID");

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress" />
    /// </summary>
    public const string Schema = "Person";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress" />
    /// </summary>
    public const string Name = "EmailAddress";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress.Id" />
    /// </summary>
    public const string Id = "EmailAddressID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress.EmailAddressMember" />
    /// </summary>
    public const string EmailAddressMember = "EmailAddress";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress.Rowguid" />
    /// </summary>
    public const string Rowguid = "rowguid";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.EmailAddress.ModifiedDate" />
    /// </summary>
    public const string ModifiedDate = "ModifiedDate";
  }

  #endregion
}
