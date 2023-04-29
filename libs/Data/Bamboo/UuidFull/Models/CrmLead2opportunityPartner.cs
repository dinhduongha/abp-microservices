﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmLead2opportunityPartner
{
    public Guid Id { get; set; }

    public Guid? LeadId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Action { get; set; }

    public bool? ForceAssignment { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmLead? Lead { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();
}
