using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosSession
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ConfigId { get; set; }

    public Guid? UserId { get; set; }

    public long? SequenceNumber { get; set; }

    public long? LoginNumber { get; set; }

    public Guid? CashJournalId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? OpeningNotes { get; set; }

    public decimal? CashRegisterBalanceEndReal { get; set; }

    public decimal? CashRegisterBalanceStart { get; set; }

    public decimal? CashRealTransaction { get; set; }

    public bool? Rescue { get; set; }

    public bool? UpdateStockAtClosing { get; set; }

    public DateTime? StartAt { get; set; }

    public DateTime? StopAt { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual AccountJournal? CashJournal { get; set; }

    public virtual PosConfig? Config { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual AccountMove? Move { get; set; }

    //public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    //public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
