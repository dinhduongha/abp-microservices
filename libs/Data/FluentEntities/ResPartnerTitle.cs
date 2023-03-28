using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResPartnerTitle
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Shortcut { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    public virtual ResUser? WriteU { get; set; }
}
