using Platy.AdventureWorks.Repository.Data.Entities;

namespace Platy.AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
///   Allows configuration for an entity type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson" />
/// </summary>
internal class VSalesPersonConfiguration
  : IEntityTypeConfiguration<VSalesPerson>
{
  /// <summary>
  ///   Configures the entity of type <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson" />
  /// </summary>
  /// <param name="builder">The builder to be used to configure the entity type.</param>
  public void Configure(EntityTypeBuilder<VSalesPerson> builder)
  {
    #region Generated Configure

    // table
    builder.ToView("vSalesPerson", "Sales");

    // key
    builder.HasNoKey();

    // properties
    builder.Property(t => t.BusinessEntityId)
      .IsRequired()
      .HasColumnName("BusinessEntityID")
      .HasColumnType("int");

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

    builder.Property(t => t.JobTitle)
      .IsRequired()
      .HasColumnName("JobTitle")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

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

    builder.Property(t => t.TerritoryName)
      .HasColumnName("TerritoryName")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.TerritoryGroup)
      .HasColumnName("TerritoryGroup")
      .HasColumnType("nvarchar(50)")
      .HasMaxLength(50);

    builder.Property(t => t.SalesQuota)
      .HasColumnName("SalesQuota")
      .HasColumnType("money");

    builder.Property(t => t.SalesYTD)
      .IsRequired()
      .HasColumnName("SalesYTD")
      .HasColumnType("money");

    builder.Property(t => t.SalesLastYear)
      .IsRequired()
      .HasColumnName("SalesLastYear")
      .HasColumnType("money");

    // relationships

    #endregion
  }

  #region Generated Constants

  internal readonly struct Table
  {
    /// <summary>
    ///   Table Schema name constant for entity
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson" />
    /// </summary>
    public const string Schema = "Sales";

    /// <summary>
    ///   Table Name constant for entity <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson" />
    /// </summary>
    public const string Name = "vSalesPerson";
  }

  internal readonly struct Columns
  {
    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.BusinessEntityId" />
    /// </summary>
    public const string BusinessEntityId = "BusinessEntityID";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.Title" />
    /// </summary>
    public const string Title = "Title";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.FirstName" />
    /// </summary>
    public const string FirstName = "FirstName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.MiddleName" />
    /// </summary>
    public const string MiddleName = "MiddleName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.LastName" />
    /// </summary>
    public const string LastName = "LastName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.Suffix" />
    /// </summary>
    public const string Suffix = "Suffix";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.JobTitle" />
    /// </summary>
    public const string JobTitle = "JobTitle";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.PhoneNumber" />
    /// </summary>
    public const string PhoneNumber = "PhoneNumber";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.PhoneNumberType" />
    /// </summary>
    public const string PhoneNumberType = "PhoneNumberType";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.EmailAddress" />
    /// </summary>
    public const string EmailAddress = "EmailAddress";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.EmailPromotion" />
    /// </summary>
    public const string EmailPromotion = "EmailPromotion";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.AddressLine1" />
    /// </summary>
    public const string AddressLine1 = "AddressLine1";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.AddressLine2" />
    /// </summary>
    public const string AddressLine2 = "AddressLine2";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.City" />
    /// </summary>
    public const string City = "City";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.StateProvinceName" />
    /// </summary>
    public const string StateProvinceName = "StateProvinceName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.PostalCode" />
    /// </summary>
    public const string PostalCode = "PostalCode";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.CountryRegionName" />
    /// </summary>
    public const string CountryRegionName = "CountryRegionName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.TerritoryName" />
    /// </summary>
    public const string TerritoryName = "TerritoryName";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.TerritoryGroup" />
    /// </summary>
    public const string TerritoryGroup = "TerritoryGroup";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.SalesQuota" />
    /// </summary>
    public const string SalesQuota = "SalesQuota";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.SalesYTD" />
    /// </summary>
    public const string SalesYTD = "SalesYTD";

    /// <summary>
    ///   Column Name constant for property
    ///   <see cref="Platy.AdventureWorks.Repository.Data.Entities.VSalesPerson.SalesLastYear" />
    /// </summary>
    public const string SalesLastYear = "SalesLastYear";
  }

  #endregion
}
