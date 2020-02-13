using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoneyBee.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    TextAddress = table.Column<string>(nullable: true),
                    TextAddress1 = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ParentCategoryId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    ChargeTax = table.Column<bool>(nullable: false),
                    DefaultTaxId = table.Column<int>(nullable: true),
                    TrackTime = table.Column<bool>(nullable: false),
                    DefaultShippingMethodId = table.Column<int>(nullable: true),
                    DefualtFOBId = table.Column<int>(nullable: true),
                    UsePricingRules = table.Column<bool>(nullable: false),
                    UseMultipleCurrencies = table.Column<bool>(nullable: false),
                    HomeCurrencyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Continent = table.Column<string>(nullable: true),
                    FlagIconUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    OwnerType = table.Column<int>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    Required = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FOBs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOBs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    PaymentMethodType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Descripion = table.Column<string>(nullable: true),
                    DateDriven = table.Column<bool>(nullable: false),
                    NetDueIn = table.Column<int>(nullable: false),
                    DiscountPercentage = table.Column<decimal>(nullable: false),
                    DiscountIfPaidWithin = table.Column<int>(nullable: false),
                    NetDueBefore = table.Column<int>(nullable: false),
                    DueNextMonthIfIssued = table.Column<int>(nullable: false),
                    DiscountIfPaidBefore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricingRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsofMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    UOMType = table.Column<int>(nullable: false),
                    Abbreviation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ReadOnly = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsofMeasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    BankCode = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banks_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISOCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    ThousandSeparator = table.Column<int>(nullable: false),
                    DecimalSeparator = table.Column<int>(nullable: false),
                    GroupingFormat = table.Column<string>(nullable: true),
                    DecimalPlaces = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currencies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomFieldListValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    CustomFieldId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldListValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomFieldListValues_CustomFields_CustomFieldId",
                        column: x => x.CustomFieldId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UOMConversions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    UoMFromId = table.Column<int>(nullable: false),
                    UoMToId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Factor = table.Column<decimal>(nullable: false),
                    Multiply = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOMConversions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UOMConversions_UnitsofMeasures_UoMFromId",
                        column: x => x.UoMFromId,
                        principalTable: "UnitsofMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UOMConversions_UnitsofMeasures_UoMToId",
                        column: x => x.UoMToId,
                        principalTable: "UnitsofMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BankBranches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(nullable: false),
                    BranchCode = table.Column<string>(nullable: true),
                    BranchName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBranches_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyConversions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyId = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyConversions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyConversions_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    TransactionType = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    EnteredDate = table.Column<DateTime>(nullable: false),
                    ReferenceNumber = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: false),
                    ExcangeRate = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    PaymentTermId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentTerms_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalTable: "PaymentTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    BankBranchId = table.Column<int>(nullable: true),
                    BankId = table.Column<int>(nullable: true),
                    CreditCardNumber = table.Column<string>(nullable: true),
                    CreditCardExpiryMonth = table.Column<int>(nullable: false),
                    CreditCardExpiryYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_BankBranches_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "BankBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    AltPhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CCEmail = table.Column<string>(nullable: true),
                    DefaultAddressId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    PaymentTermId = table.Column<int>(nullable: true),
                    CreditLimit = table.Column<decimal>(nullable: false),
                    ChartofAccountId = table.Column<int>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    CurrencyBalance = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    SalesRepId = table.Column<int>(nullable: true),
                    TaxId = table.Column<int>(nullable: true),
                    TaxRegistrationNumber = table.Column<string>(nullable: true),
                    Month = table.Column<int>(nullable: true),
                    ReportingFrequency = table.Column<int>(nullable: true),
                    ReportingMethod = table.Column<int>(nullable: true),
                    PurchasesAccountId = table.Column<int>(nullable: true),
                    SalesAccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entities_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entities_Addresses_DefaultAddressId",
                        column: x => x.DefaultAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entities_PaymentTerms_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalTable: "PaymentTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityAddresses_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    ProjectTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Entities_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Categories_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesReps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    EntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReps_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    TaxAgencyId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Taxable = table.Column<bool>(nullable: false),
                    CollectedOnSales = table.Column<bool>(nullable: false),
                    SalesRate = table.Column<decimal>(nullable: false),
                    CollectedOnPurchases = table.Column<bool>(nullable: false),
                    PurchaseRate = table.Column<decimal>(nullable: false),
                    PurchaseTaxIsReclaimable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Taxes_Entities_TaxAgencyId",
                        column: x => x.TaxAgencyId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChartofAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    AccountType = table.Column<int>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: false),
                    ParentAccountId = table.Column<int>(nullable: true),
                    TaxId = table.Column<int>(nullable: true),
                    BankAccountNumber = table.Column<string>(nullable: true),
                    BankBranchId = table.Column<int>(nullable: true),
                    BankId = table.Column<int>(nullable: true),
                    BlockDirectPosting = table.Column<bool>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CurrencyBalance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartofAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChartofAccounts_BankBranches_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "BankBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChartofAccounts_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChartofAccounts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChartofAccounts_ChartofAccounts_ParentAccountId",
                        column: x => x.ParentAccountId,
                        principalTable: "ChartofAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChartofAccounts_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    UPC = table.Column<string>(nullable: true),
                    PurchaseDescription = table.Column<string>(nullable: true),
                    SalesDescription = table.Column<string>(nullable: true),
                    StandardCost = table.Column<decimal>(nullable: false),
                    AverageCost = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    IsSubItem = table.Column<bool>(nullable: false),
                    ItemIsPurchased = table.Column<bool>(nullable: false),
                    AmountInclusiveOfTax = table.Column<bool>(nullable: false),
                    RateIsPercent = table.Column<bool>(nullable: false),
                    ManufacturerNo = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    PurchaseTaxId = table.Column<int>(nullable: true),
                    SalesTaxId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    ExpenseAccountId = table.Column<int>(nullable: true),
                    AssestAccountId = table.Column<int>(nullable: true),
                    IncomeAccountId = table.Column<int>(nullable: true),
                    AdjustmentAccountId = table.Column<int>(nullable: true),
                    ScrapAccountId = table.Column<int>(nullable: true),
                    UOMId = table.Column<int>(nullable: true),
                    ParentItemId = table.Column<int>(nullable: true),
                    OnHand = table.Column<decimal>(nullable: false),
                    OnOrder = table.Column<decimal>(nullable: false),
                    BackOrdered = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Items_ParentItemId",
                        column: x => x.ParentItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Taxes_PurchaseTaxId",
                        column: x => x.PurchaseTaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Taxes_SalesTaxId",
                        column: x => x.SalesTaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_UnitsofMeasures_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UnitsofMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    LineNumber = table.Column<int>(nullable: false),
                    TransactionId = table.Column<int>(nullable: false),
                    EnteredDate = table.Column<DateTime>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    TaxItemId = table.Column<int>(nullable: true),
                    CostcenterId = table.Column<int>(nullable: true),
                    UOMId = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Custom1 = table.Column<string>(nullable: true),
                    Custom2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Categories_CostcenterId",
                        column: x => x.CostcenterId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Taxes_TaxItemId",
                        column: x => x.TaxItemId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_UnitsofMeasures_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UnitsofMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JournalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    JournalLine = table.Column<int>(nullable: false),
                    TransactionId = table.Column<int>(nullable: false),
                    TransactionDetalId = table.Column<int>(nullable: true),
                    AccountId = table.Column<int>(nullable: false),
                    TaxId = table.Column<int>(nullable: true),
                    EntityId = table.Column<int>(nullable: true),
                    CostcenterId = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    EnteredDate = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    ExcangeRate = table.Column<decimal>(nullable: false),
                    CurrencyAmount = table.Column<decimal>(nullable: false),
                    Debit = table.Column<decimal>(nullable: false),
                    Credit = table.Column<decimal>(nullable: false),
                    Posted = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalDetails_ChartofAccounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "ChartofAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JournalDetails_Categories_CostcenterId",
                        column: x => x.CostcenterId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournalDetails_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_JournalDetails_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournalDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournalDetails_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournalDetails_TransactionDetails_TransactionDetalId",
                        column: x => x.TransactionDetalId,
                        principalTable: "TransactionDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournalDetails_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DefaultBinId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(nullable: false),
                    InActive = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AvailableForSale = table.Column<bool>(nullable: false),
                    Pickable = table.Column<bool>(nullable: false),
                    Receivable = table.Column<bool>(nullable: false),
                    WarehouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bins_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankBranches_BankId",
                table: "BankBranches",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_CountryId",
                table: "Banks",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bins_WarehouseId",
                table: "Bins",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartofAccounts_BankBranchId",
                table: "ChartofAccounts",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartofAccounts_BankId",
                table: "ChartofAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartofAccounts_CurrencyId",
                table: "ChartofAccounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartofAccounts_ParentAccountId",
                table: "ChartofAccounts",
                column: "ParentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartofAccounts_TaxId",
                table: "ChartofAccounts",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_CountryId",
                table: "Currencies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyConversions_CurrencyId",
                table: "CurrencyConversions",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFieldListValues_CustomFieldId",
                table: "CustomFieldListValues",
                column: "CustomFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_SalesRepId",
                table: "Entities",
                column: "SalesRepId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_TaxId",
                table: "Entities",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_CategoryId",
                table: "Entities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ChartofAccountId",
                table: "Entities",
                column: "ChartofAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_CurrencyId",
                table: "Entities",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_DefaultAddressId",
                table: "Entities",
                column: "DefaultAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_PaymentTermId",
                table: "Entities",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_PurchasesAccountId",
                table: "Entities",
                column: "PurchasesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_SalesAccountId",
                table: "Entities",
                column: "SalesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAddresses_AddressId",
                table: "EntityAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAddresses_EntityId",
                table: "EntityAddresses",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ParentItemId",
                table: "Items",
                column: "ParentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PurchaseTaxId",
                table: "Items",
                column: "PurchaseTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SalesTaxId",
                table: "Items",
                column: "SalesTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UOMId",
                table: "Items",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_AccountId",
                table: "JournalDetails",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_CostcenterId",
                table: "JournalDetails",
                column: "CostcenterId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_CurrencyId",
                table: "JournalDetails",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_EntityId",
                table: "JournalDetails",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_ItemId",
                table: "JournalDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_TaxId",
                table: "JournalDetails",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_TransactionDetalId",
                table: "JournalDetails",
                column: "TransactionDetalId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalDetails_TransactionId",
                table: "JournalDetails",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_BankBranchId",
                table: "PaymentDetails",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_BankId",
                table: "PaymentDetails",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_PaymentMethodId",
                table: "PaymentDetails",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReps_EntityId",
                table: "SalesReps",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxes_TaxAgencyId",
                table: "Taxes",
                column: "TaxAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_CostcenterId",
                table: "TransactionDetails",
                column: "CostcenterId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_ItemId",
                table: "TransactionDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TaxItemId",
                table: "TransactionDetails",
                column: "TaxItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TransactionId",
                table: "TransactionDetails",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_UOMId",
                table: "TransactionDetails",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentTermId",
                table: "Transactions",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CurrencyId",
                table: "Transactions",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_UOMConversions_UoMFromId",
                table: "UOMConversions",
                column: "UoMFromId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UOMConversions_UoMToId",
            //    table: "UOMConversions",
            //    column: "UoMToId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_DefaultBinId",
                table: "Warehouses",
                column: "DefaultBinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entities_Taxes_TaxId",
                table: "Entities",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entities_SalesReps_SalesRepId",
                table: "Entities",
                column: "SalesRepId",
                principalTable: "SalesReps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entities_ChartofAccounts_ChartofAccountId",
                table: "Entities",
                column: "ChartofAccountId",
                principalTable: "ChartofAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entities_ChartofAccounts_PurchasesAccountId",
                table: "Entities",
                column: "PurchasesAccountId",
                principalTable: "ChartofAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entities_ChartofAccounts_SalesAccountId",
                table: "Entities",
                column: "SalesAccountId",
                principalTable: "ChartofAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Bins_DefaultBinId",
                table: "Warehouses",
                column: "DefaultBinId",
                principalTable: "Bins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_Banks_BankId",
                table: "BankBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartofAccounts_Banks_BankId",
                table: "ChartofAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Countries_CountryId",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Bins_Warehouses_WarehouseId",
                table: "Bins");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartofAccounts_BankBranches_BankBranchId",
                table: "ChartofAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartofAccounts_Currencies_CurrencyId",
                table: "ChartofAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Entities_Currencies_CurrencyId",
                table: "Entities");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartofAccounts_Taxes_TaxId",
                table: "ChartofAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Entities_Taxes_TaxId",
                table: "Entities");

            migrationBuilder.DropForeignKey(
                name: "FK_Entities_SalesReps_SalesRepId",
                table: "Entities");

            migrationBuilder.DropTable(
                name: "CompanyPreferences");

            migrationBuilder.DropTable(
                name: "CurrencyConversions");

            migrationBuilder.DropTable(
                name: "CustomFieldListValues");

            migrationBuilder.DropTable(
                name: "EntityAddresses");

            migrationBuilder.DropTable(
                name: "FOBs");

            migrationBuilder.DropTable(
                name: "JournalDetails");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "PricingRules");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ShippingMethods");

            migrationBuilder.DropTable(
                name: "UOMConversions");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "CustomFields");

            migrationBuilder.DropTable(
                name: "TransactionDetails");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UnitsofMeasures");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Bins");

            migrationBuilder.DropTable(
                name: "BankBranches");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "SalesReps");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ChartofAccounts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "PaymentTerms");
        }
    }
}
