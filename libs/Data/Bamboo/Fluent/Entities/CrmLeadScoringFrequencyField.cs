using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrmLeadScoringFrequencyField
{
    public Guid Id { get; set; }

    public Guid? FieldId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdates { get; } = new List<CrmLeadPlsUpdate>();
}
