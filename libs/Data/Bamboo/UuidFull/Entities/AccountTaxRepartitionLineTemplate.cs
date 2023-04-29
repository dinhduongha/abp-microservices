using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_tax_repartition_line_template")]
public partial class AccountTaxRepartitionLineTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("invoice_tax_id")]
    public Guid? InvoiceTaxId { get; set; }

    [Column("refund_tax_id")]
    public Guid? RefundTaxId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("repartition_type")]
    public string? RepartitionType { get; set; }

    [Column("use_in_tax_closing")]
    public bool? UseInTaxClosing { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("factor_percent")]
    public double? FactorPercent { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("AccountTaxRepartitionLineTemplates")]
    public virtual AccountAccountTemplate? Account { get; set; }

    [InverseProperty("AccountTaxRepartitionLineTemplate")]
    public virtual ICollection<AccountTaxRepartitionFinancialTag> AccountTaxRepartitionFinancialTags { get; } = new List<AccountTaxRepartitionFinancialTag>();

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountTaxRepartitionLineTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceTaxId")]
    [InverseProperty("AccountTaxRepartitionLineTemplateInvoiceTaxes")]
    public virtual AccountTaxTemplate? InvoiceTax { get; set; }

    [ForeignKey("RefundTaxId")]
    [InverseProperty("AccountTaxRepartitionLineTemplateRefundTaxes")]
    public virtual AccountTaxTemplate? RefundTax { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountTaxRepartitionLineTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountTaxRepartitionLineTemplateId")]
    [InverseProperty("AccountTaxRepartitionLineTemplates")]
    public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; } = new List<AccountReportExpression>();

    [ForeignKey("AccountTaxRepartitionLineTemplateId")]
    [InverseProperty("AccountTaxRepartitionLineTemplatesNavigation")]
    public virtual ICollection<AccountReportExpression> AccountReportExpressionsNavigation { get; } = new List<AccountReportExpression>();
}
