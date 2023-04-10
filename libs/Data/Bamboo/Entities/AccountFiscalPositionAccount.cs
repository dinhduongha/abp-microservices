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

[Table("account_fiscal_position_account")]
[Index("PositionId", "AccountSrcId", "AccountDestId", Name = "account_fiscal_position_account_account_src_dest_uniq", IsUnique = true)]
public partial class AccountFiscalPositionAccount: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("position_id")]
    public Guid? PositionId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

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
    //[InverseProperty("AccountFiscalPositionAccountAccountDests")]
    public virtual AccountAccount? AccountDest { get; set; }

    [ForeignKey("AccountSrcId")]
    //[InverseProperty("AccountFiscalPositionAccountAccountSrcs")]
    public virtual AccountAccount? AccountSrc { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("AccountFiscalPositionAccounts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountFiscalPositionAccountCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PositionId")]
    //[InverseProperty("AccountFiscalPositionAccounts")]
    public virtual AccountFiscalPosition? Position { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountFiscalPositionAccountWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
