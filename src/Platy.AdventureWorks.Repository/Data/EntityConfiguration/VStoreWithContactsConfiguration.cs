using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type
///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts" />
/// </summary>
internal class VStoreWithContactsConfiguration
  : IEntityTypeConfiguration<VStoreWithContacts>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<VStoreWithContacts> builder)
  {
    #region Generated Configure

    // table
    builder.ToView("vStoreWithContacts", "Sales");

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

    builder.Property(t => t.ContactType)
      .IsRequired()
      .HasColumnName("ContactType")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Title)
      .HasColumnName("Title")
      .HasColumnType("nvarchar(8)")
      .HasMaxLength(8);

    builder.Property(t => t.FirstName)
      .IsRequired()
      .HasColumnName("FirstName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.MiddleName)
      .HasColumnName("MiddleName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.LastName)
      .IsRequired()
      .HasColumnName("LastName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.Suffix)
      .HasColumnName("Suffix")
      .HasColumnType("nvarchar(10)")
      .HasMaxLength(10);

    builder.Property(t => t.PhoneNumber)
      .HasColumnName("PhoneNumber")
      .HasColumnType("nvarchar(25)")
      .HasMaxLength(25);

    builder.Property(t => t.PhoneNumberType)
      .HasColumnName("PhoneNumberType")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.EmailAddress)
      .HasColumnName("EmailAddress")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.EmailPromotion)
      .IsRequired()
      .HasColumnName("EmailPromotion")
      .HasColumnType("int");

    // relationships

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts" />
    /// </summary>
    public const string Name = "vStoreWithContacts";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.Name" />
    /// </summary>
    public const string Name = "Name";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.ContactType" />
    /// </summary>
    public const string ContactType = "ContactType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.Title" />
    /// </summary>
    public const string Title = "Title";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.FirstName" />
    /// </summary>
    public const string FirstName = "FirstName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.MiddleName" />
    /// </summary>
    public const string MiddleName = "MiddleName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.LastName" />
    /// </summary>
    public const string LastName = "LastName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.Suffix" />
    /// </summary>
    public const string Suffix = "Suffix";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.PhoneNumber" />
    /// </summary>
    public const string PhoneNumber = "PhoneNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.PhoneNumberType" />
    /// </summary>
    public const string PhoneNumberType = "PhoneNumberType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.EmailAddress" />
    /// </summary>
    public const string EmailAddress = "EmailAddress";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VStoreWithContacts.EmailPromotion" />
    /// </summary>
    public const string EmailPromotion = "EmailPromotion";
  }

  #endregion
}
