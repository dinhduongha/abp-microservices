using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmLeadScoringFrequencyField
{
    public Guid Id { get; set; }

    public Guid? FieldId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdates { get; } = new List<CrmLeadPlsUpdate>();
}
