using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PrivacyLookupWizard
{
    public Guid Id { get; set; }

    public Guid? LogId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? ExecutionDetails { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PrivacyLog? Log { get; set; }

    //public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLines { get; } = new List<PrivacyLookupWizardLine>();

    public virtual ResUser? WriteU { get; set; }
}
