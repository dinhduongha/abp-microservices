using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PrivacyLookupWizardLine
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? ResId { get; set; }

    public Guid? ResModelId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResName { get; set; }

    public string? ResModel { get; set; }

    public string? ExecutionDetails { get; set; }

    public bool? HasActive { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsUnlinked { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual PrivacyLookupWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
