﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("repartition_type")]
    public string? RepartitionType { get; set; }

    [Column("use_in_tax_closing")]
    public bool? UseInTaxClosing { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("factor_percent")]
    public double? FactorPercent { get; set; }

    [ForeignKey("AccountId")]
    //[InverseProperty("AccountTaxRepartitionLineTemplates")]
    public virtual AccountAccountTemplate? Account { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountTaxRepartitionLineTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceTaxId")]
    //[InverseProperty("AccountTaxRepartitionLineTemplateInvoiceTaxes")]
    public virtual AccountTaxTemplate? InvoiceTax { get; set; }

    [ForeignKey("RefundTaxId")]
    //[InverseProperty("AccountTaxRepartitionLineTemplateRefundTaxes")]
    public virtual AccountTaxTemplate? RefundTax { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountTaxRepartitionLineTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountTaxRepartitionLineTemplateId")]
    [InverseProperty("AccountTaxRepartitionLineTemplates")]
    [NotMapped]
    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();

    [ForeignKey("AccountTaxRepartitionLineTemplateId")]
    [InverseProperty("AccountTaxRepartitionLineTemplates")]
    [NotMapped]
    public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; } = new List<AccountReportExpression>();

    //[ForeignKey("AccountTaxRepartitionLineTemplateId")]
    [InverseProperty("AccountTaxRepartitionLineTemplatesNavigation")]
    [NotMapped]
    public virtual ICollection<AccountReportExpression> AccountReportExpressionsNavigation { get; } = new List<AccountReportExpression>();
}
