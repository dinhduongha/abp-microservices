using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("account_fiscal_position_tax_template")]
public partial class AccountFiscalPositionTaxTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("position_id")]
    public Guid? PositionId { get; set; }

    [Column("tax_src_id")]
    public Guid? TaxSrcId { get; set; }

    [Column("tax_dest_id")]
    public Guid? TaxDestId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountFiscalPositionTaxTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PositionId")]
    [InverseProperty("AccountFiscalPositionTaxTemplates")]
    public virtual AccountFiscalPositionTemplate? Position { get; set; }

    [ForeignKey("TaxDestId")]
    [InverseProperty("AccountFiscalPositionTaxTemplateTaxDests")]
    public virtual AccountTaxTemplate? TaxDest { get; set; }

    [ForeignKey("TaxSrcId")]
    [InverseProperty("AccountFiscalPositionTaxTemplateTaxSrcs")]
    public virtual AccountTaxTemplate? TaxSrc { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountFiscalPositionTaxTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
