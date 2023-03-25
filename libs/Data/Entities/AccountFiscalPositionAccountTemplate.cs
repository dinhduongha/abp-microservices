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

[Table("account_fiscal_position_account_template")]
public partial class AccountFiscalPositionAccountTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("position_id")]
    public Guid? PositionId { get; set; }

    [Column("account_src_id")]
    public Guid? AccountSrcId { get; set; }

    [Column("account_dest_id")]
    public Guid? AccountDestId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AccountDestId")]
    [InverseProperty("AccountFiscalPositionAccountTemplateAccountDests")]
    public virtual AccountAccountTemplate? AccountDest { get; set; }

    [ForeignKey("AccountSrcId")]
    [InverseProperty("AccountFiscalPositionAccountTemplateAccountSrcs")]
    public virtual AccountAccountTemplate? AccountSrc { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountFiscalPositionAccountTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PositionId")]
    [InverseProperty("AccountFiscalPositionAccountTemplates")]
    public virtual AccountFiscalPositionTemplate? Position { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountFiscalPositionAccountTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
