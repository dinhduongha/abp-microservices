using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BasePartnerMergeLine
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? MinId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AggrIds { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ResUser? CreateU { get; set; }

    public virtual BasePartnerMergeAutomaticWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
