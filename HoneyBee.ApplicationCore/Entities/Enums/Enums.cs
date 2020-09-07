using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities.Enums
{
    public enum Month
    {
        All,
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public enum ReportingFrequency
    {
        Daily,
        Weekly,
        BiWeekly,
        Monthly,
        Quartely,
        HalfYeary,
        Yearly
    }

    public enum ReportingMethod
    {
        Cash,
        Accrual
    }

    public enum ItemType
    {
        Service,
        Inventory,
        InternalUse,
        OtherCharge,
        Group,
        Assembly,
        Subtotal,
        Discount
    }

    public enum AccountType
    {
        /// <summary>
        /// Accounts that you hold at a financial institution, such as a checking, savings, money market, or petty cash account.
        /// </summary>
        Bank,
        /// <summary>
        /// The money that your customers owe you, like outstanding invoices and goods purchased on credit.
        /// </summary>
        AccountsReceivable,
        /// <summary>
        /// Things you own that you’ll use or convert to cash within 12 months, such as prepaid expenses.
        /// </summary>
        OtherCurrrentAsset,
        /// <summary>
        /// Things your company owns that decrease in value over time (depreciate).
        /// </summary>
        FixedAsset,
        /// <summary>
        /// Assets that won’t be converted to cash in the next 12 months and don't depreciate
        /// </summary>
        OtherAsset,
        /// <summary>
        /// This is a special type of current liability account that represents what you owe to suppliers.
        /// </summary>
        AccountsPayable,
        /// <summary>
        /// Money you owe in the next 12 months, such as sales tax and short-term loans.
        /// </summary>
        OtherCurrentLiability,
        /// <summary>
        /// Money you owe after the next 12 months, like mortgage payments you’ll pay over several years.
        /// </summary>
        LongTermLiability,
        /// <summary>
        /// The owners’ equity in your company, including the original capital invested in the company and retained earnings.
        /// </summary>
        Equity,
        /// <summary>
        /// The revenue you generate through your main business functions, like sales or consulting services.
        /// </summary>
        Income,
        /// <summary>
        /// Money you receive from sources other than business operations, such as interest income.
        /// </summary>
        OtherIncome,
        /// <summary>
        /// The money you spend to run your company.
        /// </summary>
        Expense,
        /// <summary>
        /// The cost of products and materials that you originally held in inventory but then sold.
        /// </summary>
        COGS,
        /// <summary>
        /// Money you pay out for things other than business operations, like interest.
        /// </summary>
        OtherExpense


    }

    public enum CategoryType
    {
        /// <summary>
        /// Costcenter
        /// </summary>
        PandL,
        StockItem,
        CustomerType,
        SupplierType,
        ProjectType
    }

    public enum PaymentMethodType
    {
        Cash,
        Cheque,
        CreditCard,
        DebitCard,
        MobileMoney,
        Other
    }

    public enum TransactionType
    {
        All,
        Journal,
        Quotation,
        Invoice,
        CreditNote,
        CashSale,
        DebitNote,
        Requisition,
        PurchaseOrder,
        GoodsReceivedNote,
        GoodsIssueNote,
        GoodsReturnedNote,
        PaymentReceipt
    }

    public enum FormatSeparator
    {
        Comma,
        Period,
        Space
    }

    public enum CustomFieldType
    {
        Customer,
        Supplier,
        Employee,
        OtherName,
        Item
    }

    public enum CustomFieldDataType
    {
        String,
        Numeric,
        Date,
        List
    }

    public enum UOMType
    {
        Count,
        Weight,
        Length,
        Area,
        Volume,
        Time
    }

    public enum SubscriptionType
    {
        Service,
        GeneralSupplies
    }
}
