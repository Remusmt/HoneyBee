using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HoneyBee.Infrastructure.Data
{
    public class HoneyBeeContextFactory : IDesignTimeDbContextFactory<HoneyBeeContext>
    {
        public HoneyBeeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HoneyBeeContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-LPOGMEO\\SQLEXPRESS;Database=HoneyBeeContextDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new HoneyBeeContext(optionsBuilder.Options);
        }
    }
    public class HoneyBeeContext : DbContext
    {
        public HoneyBeeContext(DbContextOptions<HoneyBeeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<EntityAddress> EntityAddresses { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ChartofAccount> ChartofAccounts { get; set; }
        public DbSet<CompanyPreference> CompanyPreferences { get; set; }
        public DbSet<Costcenter> Costcenters { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyConversion> CurrencyConversions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<CustomField> CustomFields { get; set; }
        public DbSet<CustomFieldListValue> CustomFieldListValues { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<FOB> FOBs { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<JournalDetail> JournalDetails { get; set; }
        public DbSet<OtherName> OtherNames { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }
        public DbSet<PricingRule> PricingRules { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<SalesRep> SalesReps { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierType> SupplierTypes { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<TaxAgency> TaxAgencies { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<UnitsofMeasure> UnitsofMeasures { get; set; }
        public DbSet<UOMConversion> UOMConversions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
