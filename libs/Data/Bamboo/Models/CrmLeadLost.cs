using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrmLeadLost
{
    public Guid Id { get; set; }

    public long? LostReasonId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? LostFeedback { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmLostReason? LostReason { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
