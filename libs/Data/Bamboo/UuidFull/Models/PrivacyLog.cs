using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PrivacyLog
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AnonymizedName { get; set; }

    public string? AnonymizedEmail { get; set; }

    public string? ExecutionDetails { get; set; }

    public string? RecordsDescription { get; set; }

    public string? AdditionalNote { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizards { get; } = new List<PrivacyLookupWizard>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
