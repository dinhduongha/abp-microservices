using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_tax")]
[Index("Name", "CompanyId", "TypeTaxUse", "TaxScope", Name = "account_tax_name_company_uniq", IsUnique = true)]
public partial class AccountTax
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("tax_group_id")]
    public Guid? TaxGroupId { get; set; }

    [Column("cash_basis_transition_account_id")]
    public Guid? CashBasisTransitionAccountId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("type_tax_use")]
    public string? TypeTaxUse { get; set; }

    [Column("tax_scope")]
    public string? TaxScope { get; set; }

    [Column("amount_type")]
    public string? AmountType { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("tax_exigibility")]
    public string? TaxExigibility { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("price_include")]
    public bool? PriceInclude { get; set; }

    [Column("include_base_amount")]
    public bool? IncludeBaseAmount { get; set; }

    [Column("is_base_affected")]
    public bool? IsBaseAffected { get; set; }

    [Column("analytic")]
    public bool? Analytic { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("real_amount")]
    public double? RealAmount { get; set; }

    [InverseProperty("TaxDest")]
    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxTaxDests { get; } = new List<AccountFiscalPositionTax>();

    [InverseProperty("TaxSrc")]
    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxTaxSrcs { get; } = new List<AccountFiscalPositionTax>();

    [InverseProperty("GroupTax")]
    public virtual ICollection<AccountMoveLine> AccountMoveLineGroupTaxes { get; } = new List<AccountMoveLine>();

    [InverseProperty("TaxLine")]
    public virtual ICollection<AccountMoveLine> AccountMoveLineTaxLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("InvoiceTax")]
    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineInvoiceTaxes { get; } = new List<AccountTaxRepartitionLine>();

    [InverseProperty("RefundTax")]
    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineRefundTaxes { get; } = new List<AccountTaxRepartitionLine>();

    [ForeignKey("CashBasisTransitionAccountId")]
    [InverseProperty("AccountTaxes")]
    public virtual AccountAccount? CashBasisTransitionAccount { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountTaxes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountTaxCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("AccountPurchaseTax")]
    public virtual ICollection<ResCompany> ResCompanyAccountPurchaseTaxes { get; } = new List<ResCompany>();

    [InverseProperty("AccountSaleTax")]
    public virtual ICollection<ResCompany> ResCompanyAccountSaleTaxes { get; } = new List<ResCompany>();

    [ForeignKey("TaxGroupId")]
    [InverseProperty("AccountTaxes")]
    public virtual AccountTaxGroup? TaxGroup { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountTaxWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; } = new List<AccountReconcileModelLine>();

    [ForeignKey("TaxId")]
    [InverseProperty("Taxes")]
    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();

    [ForeignKey("ParentTax")]
    [InverseProperty("ParentTaxes")]
    public virtual ICollection<AccountTax> ChildTaxes { get; } = new List<AccountTax>();

    [ForeignKey("TaxId")]
    [InverseProperty("Taxes")]
    public virtual ICollection<HrExpense> Expenses { get; } = new List<HrExpense>();

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [ForeignKey("ChildTax")]
    [InverseProperty("ChildTaxes")]
    public virtual ICollection<AccountTax> ParentTaxes { get; } = new List<AccountTax>();

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    [ForeignKey("TaxId")]
    [InverseProperty("Taxes")]
    public virtual ICollection<ProductTemplate> Prods { get; } = new List<ProductTemplate>();

    [ForeignKey("TaxId")]
    [InverseProperty("TaxesNavigation")]
    public virtual ICollection<ProductTemplate> ProdsNavigation { get; } = new List<ProductTemplate>();

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [ForeignKey("TaxId")]
    [InverseProperty("Taxes")]
    public virtual ICollection<RepairFee> RepairFeeLines { get; } = new List<RepairFee>();

    [ForeignKey("TaxId")]
    [InverseProperty("Taxes")]
    public virtual ICollection<RepairLine> RepairOperationLines { get; } = new List<RepairLine>();

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    [ForeignKey("AccountTaxId")]
    [InverseProperty("AccountTaxes")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();
}
