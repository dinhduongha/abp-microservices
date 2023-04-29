using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountTax
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public long Sequence { get; set; }

    public Guid? TaxGroupId { get; set; }

    public Guid? CashBasisTransitionAccountId { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? TypeTaxUse { get; set; }

    public string? TaxScope { get; set; }

    public string? AmountType { get; set; }

    public string? Description { get; set; }

    public string? TaxExigibility { get; set; }

    public decimal? Amount { get; set; }

    public bool? Active { get; set; }

    public bool? PriceInclude { get; set; }

    public bool? IncludeBaseAmount { get; set; }

    public bool? IsBaseAffected { get; set; }

    public bool? Analytic { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? RealAmount { get; set; }

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxTaxDests { get; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxTaxSrcs { get; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineGroupTaxes { get; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineTaxLines { get; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineInvoiceTaxes { get; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineRefundTaxes { get; } = new List<AccountTaxRepartitionLine>();

    public virtual AccountAccount? CashBasisTransitionAccount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResCompany> ResCompanyAccountPurchaseTaxes { get; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountSaleTaxes { get; } = new List<ResCompany>();

    public virtual AccountTaxGroup? TaxGroup { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();

    public virtual ICollection<AccountTax> ChildTaxes { get; } = new List<AccountTax>();

    public virtual ICollection<HrExpense> Expenses { get; } = new List<HrExpense>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    public virtual ICollection<AccountTax> ParentTaxes { get; } = new List<AccountTax>();

    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    public virtual ICollection<ProductTemplate> Prods { get; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProdsNavigation { get; } = new List<ProductTemplate>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RepairFee> RepairFeeLines { get; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairOperationLines { get; } = new List<RepairLine>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();
}
