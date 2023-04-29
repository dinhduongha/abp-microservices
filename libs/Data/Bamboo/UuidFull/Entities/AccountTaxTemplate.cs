using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_tax_template")]
[Index("Name", "TypeTaxUse", "TaxScope", "ChartTemplateId", Name = "account_tax_template_name_company_uniq", IsUnique = true)]
public partial class AccountTaxTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("chart_template_id")]
    public Guid? ChartTemplateId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("tax_group_id")]
    public Guid? TaxGroupId { get; set; }

    [Column("cash_basis_transition_account_id")]
    public Guid? CashBasisTransitionAccountId { get; set; }

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

    [InverseProperty("TaxDest")]
    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateTaxDests { get; } = new List<AccountFiscalPositionTaxTemplate>();

    [InverseProperty("TaxSrc")]
    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateTaxSrcs { get; } = new List<AccountFiscalPositionTaxTemplate>();

    [InverseProperty("InvoiceTax")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateInvoiceTaxes { get; } = new List<AccountTaxRepartitionLineTemplate>();

    [InverseProperty("RefundTax")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateRefundTaxes { get; } = new List<AccountTaxRepartitionLineTemplate>();

    [ForeignKey("CashBasisTransitionAccountId")]
    [InverseProperty("AccountTaxTemplates")]
    public virtual AccountAccountTemplate? CashBasisTransitionAccount { get; set; }

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("AccountTaxTemplates")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountTaxTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TaxGroupId")]
    [InverseProperty("AccountTaxTemplates")]
    public virtual AccountTaxGroup? TaxGroup { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountTaxTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountTaxTemplateId")]
    [InverseProperty("AccountTaxTemplates")]
    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; } = new List<AccountReconcileModelLineTemplate>();

    [ForeignKey("TaxId")]
    [InverseProperty("Taxes")]
    public virtual ICollection<AccountAccountTemplate> Accounts { get; } = new List<AccountAccountTemplate>();

    [ForeignKey("ParentTax")]
    [InverseProperty("ParentTaxes")]
    public virtual ICollection<AccountTaxTemplate> ChildTaxes { get; } = new List<AccountTaxTemplate>();

    [ForeignKey("ChildTax")]
    [InverseProperty("ChildTaxes")]
    public virtual ICollection<AccountTaxTemplate> ParentTaxes { get; } = new List<AccountTaxTemplate>();
}
