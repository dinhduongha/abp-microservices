using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_full_reconcile")]
public partial class AccountFullReconcile
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("exchange_move_id")]
    public Guid? ExchangeMoveId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("FullReconcile")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("FullReconcile")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountFullReconcileCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ExchangeMoveId")]
    [InverseProperty("AccountFullReconciles")]
    public virtual AccountMove? ExchangeMove { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountFullReconcileWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
