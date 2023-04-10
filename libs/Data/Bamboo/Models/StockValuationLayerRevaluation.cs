using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockValuationLayerRevaluation
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? AccountJournalId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Reason { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? AddedValue { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual AccountJournal? AccountJournal { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
