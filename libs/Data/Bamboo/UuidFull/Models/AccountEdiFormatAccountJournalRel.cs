using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountEdiFormatAccountJournalRel
{
    public Guid AccountJournalId { get; set; }

    public long AccountEdiFormatId { get; set; }

    public virtual AccountJournal AccountJournal { get; set; } = null!;
}
