using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountMoveLine
{
    public Guid Id { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? TenantId { get; set; }

    public long? CompanyCurrencyId { get; set; }

    public long Sequence { get; set; }

    public Guid? AccountId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? ReconcileModelId { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? StatementLineId { get; set; }

    public Guid? StatementId { get; set; }

    public Guid? GroupTaxId { get; set; }

    public Guid? TaxLineId { get; set; }

    public Guid? TaxGroupId { get; set; }

    public Guid? TaxRepartitionLineId { get; set; }

    public Guid? FullReconcileId { get; set; }

    public Guid? AccountRootId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? MoveName { get; set; }

    public string? ParentState { get; set; }

    public string? Ref { get; set; }

    public string? Name { get; set; }

    public string? TaxAudit { get; set; }

    public string? MatchingNumber { get; set; }

    public string? DisplayType { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? DateMaturity { get; set; }

    public DateOnly? DiscountDate { get; set; }

    public string? AnalyticDistribution { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Balance { get; set; }

    public decimal? AmountCurrency { get; set; }

    public decimal? TaxBaseAmount { get; set; }

    public decimal? AmountResidual { get; set; }

    public decimal? AmountResidualCurrency { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountAmountCurrency { get; set; }

    public decimal? DiscountBalance { get; set; }

    public bool? TaxTagInvert { get; set; }

    public bool? Reconciled { get; set; }

    public bool? Blocked { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? DiscountPercentage { get; set; }

    public bool? IsDownpayment { get; set; }

    public Guid? PurchaseLineId { get; set; }

    public Guid? AssetCategoryId { get; set; }

    public DateOnly? AssetStartDate { get; set; }

    public DateOnly? AssetEndDate { get; set; }

    public double? AssetMrr { get; set; }

    public Guid? FollowupLineId { get; set; }

    public DateOnly? FollowupDate { get; set; }

    public Guid? ExpenseId { get; set; }

    public Guid? VehicleId { get; set; }

    public virtual AccountAccount? Account { get; set; }

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreditMoves { get; } = new List<AccountPartialReconcile>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileDebitMoves { get; } = new List<AccountPartialReconcile>();

    public virtual AccountAssetCategory? AssetCategory { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCurrency? CompanyCurrency { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual HrExpense? Expense { get; set; }

    public virtual FollowupLine? FollowupLine { get; set; }

    public virtual AccountFullReconcile? FullReconcile { get; set; }

    public virtual AccountTax? GroupTax { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual PurchaseOrderLine? PurchaseLine { get; set; }

    public virtual AccountReconcileModel? ReconcileModel { get; set; }

    //public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    public virtual AccountBankStatement? Statement { get; set; }

    public virtual AccountBankStatementLine? StatementLine { get; set; }

    //public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    public virtual AccountTaxGroup? TaxGroup { get; set; }

    public virtual AccountTax? TaxLine { get; set; }

    public virtual AccountTaxRepartitionLine? TaxRepartitionLine { get; set; }

    public virtual FleetVehicle? Vehicle { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();

    //public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; } = new List<AccountAutomaticEntryWizard>();

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    //public virtual ICollection<SaleOrderLine> OrderLines { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<AccountPaymentRegister> Wizards { get; } = new List<AccountPaymentRegister>();
}
