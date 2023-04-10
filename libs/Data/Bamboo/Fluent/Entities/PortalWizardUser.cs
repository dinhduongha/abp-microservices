using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PortalWizardUser
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Email { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual PortalWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
