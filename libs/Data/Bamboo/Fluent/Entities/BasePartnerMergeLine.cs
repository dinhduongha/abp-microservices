using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BasePartnerMergeLine
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? MinId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AggrIds { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ResUser? CreateU { get; set; }

    public virtual BasePartnerMergeAutomaticWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
