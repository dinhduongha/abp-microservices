using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountSetupBankManualConfig
{
    public Guid Id { get; set; }

    public Guid? ResPartnerBankId { get; set; }

    public long? NumJournalsWithoutAccount { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? NewJournalName { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartnerBank? ResPartnerBank { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
