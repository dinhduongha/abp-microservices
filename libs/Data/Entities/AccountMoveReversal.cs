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

[Table("account_move_reversal")]
public partial class AccountMoveReversal: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("date_mode")]
    public string? DateMode { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("refund_method")]
    public string? RefundMethod { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("AccountMoveReversals")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountMoveReversalCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    //[InverseProperty("AccountMoveReversals")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountMoveReversalWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ReversalId")]
    [InverseProperty("Reversals")]
    [NotMapped]
    public virtual ICollection<AccountMove> Moves { get; } = new List<AccountMove>();

    [ForeignKey("ReversalId")]
    [InverseProperty("ReversalsNavigation")]
    [NotMapped]
    public virtual ICollection<AccountMove> NewMoves { get; } = new List<AccountMove>();
}
