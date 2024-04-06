﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountBankStatement
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Reference { get; set; }

    public string? FirstLineIndex { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? BalanceStart { get; set; }

    public decimal? BalanceEnd { get; set; }

    public decimal? BalanceEndReal { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();
}