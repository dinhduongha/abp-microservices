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

[Table("account_full_reconcile")]
public partial class AccountFullReconcile
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("exchange_move_id")]
    public Guid? ExchangeMoveId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountFullReconcileCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ExchangeMoveId")]
    //[InverseProperty("AccountFullReconciles")]
    public virtual AccountMove? ExchangeMove { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountFullReconcileWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("FullReconcile")]
    [NotMapped]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("FullReconcile")]
    [NotMapped]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();


}
