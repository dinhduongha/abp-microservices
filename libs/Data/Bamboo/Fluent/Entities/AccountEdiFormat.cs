using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountEdiFormat
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; } = new List<AccountEdiDocument>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();
}
