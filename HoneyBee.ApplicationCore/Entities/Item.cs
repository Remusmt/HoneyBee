using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Holds items, discounts, subtotals
    /// And anything that can be added to transaction details
    /// </summary>
    public class Item : BaseEntity
    {
        public string Code { get; set; }
        public string UPC { get; set; }
        public string PurchaseDescription { get; set; }
        public string SalesDescription { get; set; }
        public decimal StandardCost { get; set; }
        public decimal AverageCost { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        public decimal Price { get; set; }
        public bool IsSubItem { get; set; }
        /// <summary>
        /// For non-tracking items
        /// </summary>
        public bool ItemIsPurchased { get; set; }
        public bool AmountInclusiveOfTax { get; set; }
        /// <summary>
        /// This is for discount item type
        /// If true the amount is a percent
        /// Saved in the Price field
        /// </summary>
        public bool RateIsPercent { get; set; }
        public string ManufacturerNo { get; set; }
        public string ImageURL { get; set; }
        public Guid? PurchaseTaxId { get; set; }
        public Guid? SalesTaxId { get; set; }
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// Use as COGS on inventory items
        /// </summary>
        public Guid? ExpenseAccountId { get; set; }
        public Guid? AssestAccountId { get; set; }
        public Guid? IncomeAccountId { get; set; }
        public Guid? AdjustmentAccountId { get; set; }
        public Guid? ScrapAccountId { get; set; }
        public Guid? UOMId { get; set; }
        public Guid? ParentItemId { get; set; }
        /// <summary>
        /// Total amount in stock
        /// </summary>
        public decimal OnHand { get; set; }
        /// <summary>
        /// Items on approved  purchase orders
        /// </summary>
        public decimal OnOrder { get; set; }
        public decimal BackOrdered { get; set; }

        public Category Category { get; set; }
        public Item ParentItem { get; set; }
        public UnitsofMeasure UnitsofMeasure { get; set; }
        public ChartofAccount ExpenseAccount { get; set; }
        public ChartofAccount AssestAccount { get; set; }
        public ChartofAccount IncomeAccount { get; set; }
        public ChartofAccount AdjustmentAccount { get; set; }
        public ChartofAccount ScrapAccount { get; set; }
    }
}
