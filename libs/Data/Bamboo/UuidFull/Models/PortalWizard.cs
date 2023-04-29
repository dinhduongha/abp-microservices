using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PortalWizard
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? WelcomeMessage { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; } = new List<PortalWizardUser>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
