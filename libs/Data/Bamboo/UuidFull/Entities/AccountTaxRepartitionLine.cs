using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_tax_repartition_line")]
public partial class AccountTaxRepartitionLine
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

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

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
    [InverseProperty("AccountTaxRepartitionLines")]
    public virtual AccountAccount? Account { get; set; }

    [InverseProperty("AccountTaxRepartitionLine")]
    public virtual ICollection<AccountAccountTagAccountTaxRepartitionLineRel> AccountAccountTagAccountTaxRepartitionLineRels { get; } = new List<AccountAccountTagAccountTaxRepartitionLineRel>();

    [InverseProperty("TaxRepartitionLine")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountTaxRepartitionLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountTaxRepartitionLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceTaxId")]
    [InverseProperty("AccountTaxRepartitionLineInvoiceTaxes")]
    public virtual AccountTax? InvoiceTax { get; set; }

    [ForeignKey("RefundTaxId")]
    [InverseProperty("AccountTaxRepartitionLineRefundTaxes")]
    public virtual AccountTax? RefundTax { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountTaxRepartitionLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
