using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountSetupBankManualConfig
{
    public Guid Id { get; set; }

    public Guid? ResPartnerBankId { get; set; }

    public long? NumJournalsWithoutAccount { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? NewJournalName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartnerBank? ResPartnerBank { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
