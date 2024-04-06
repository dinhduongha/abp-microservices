﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PrivacyLog
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AnonymizedName { get; set; }

    public string? AnonymizedEmail { get; set; }

    public string? ExecutionDetails { get; set; }

    public string? RecordsDescription { get; set; }

    public string? AdditionalNote { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizards { get; } = new List<PrivacyLookupWizard>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}