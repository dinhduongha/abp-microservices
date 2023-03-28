using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PortalWizard
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? WelcomeMessage { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; } = new List<PortalWizardUser>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
