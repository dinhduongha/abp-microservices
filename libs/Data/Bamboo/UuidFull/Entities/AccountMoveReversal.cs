using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_move_reversal")]
public partial class AccountMoveReversal
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("date_mode")]
    public string? DateMode { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("refund_method")]
    public string? RefundMethod { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountMoveReversals")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountMoveReversalCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountMoveReversals")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountMoveReversalWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ReversalId")]
    [InverseProperty("Reversals")]
    public virtual ICollection<AccountMove> Moves { get; } = new List<AccountMove>();

    [ForeignKey("ReversalId")]
    [InverseProperty("ReversalsNavigation")]
    public virtual ICollection<AccountMove> NewMoves { get; } = new List<AccountMove>();
}
