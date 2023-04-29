using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmIapLeadMiningRequest
{
    public Guid Id { get; set; }

    public long? LeadNumber { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? UserId { get; set; }

    public long? CompanySizeMin { get; set; }

    public long? CompanySizeMax { get; set; }

    public long? ContactNumber { get; set; }

    public long? PreferredRoleId { get; set; }

    public long? SeniorityId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? SearchType { get; set; }

    public string? ErrorType { get; set; }

    public string? LeadType { get; set; }

    public string? ContactFilterType { get; set; }

    public bool? FilterOnSize { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmIapLeadIndustryCrmIapLeadMiningRequestRel> CrmIapLeadIndustryCrmIapLeadMiningRequestRels { get; } = new List<CrmIapLeadIndustryCrmIapLeadMiningRequestRel>();

    public virtual ICollection<CrmIapLeadMiningRequestCrmIapLeadRoleRel> CrmIapLeadMiningRequestCrmIapLeadRoleRels { get; } = new List<CrmIapLeadMiningRequestCrmIapLeadRoleRel>();

    public virtual ICollection<CrmIapLeadMiningRequestCrmTagRel> CrmIapLeadMiningRequestCrmTagRels { get; } = new List<CrmIapLeadMiningRequestCrmTagRel>();

    public virtual ICollection<CrmIapLeadMiningRequestResCountryRel> CrmIapLeadMiningRequestResCountryRels { get; } = new List<CrmIapLeadMiningRequestResCountryRel>();

    public virtual ICollection<CrmIapLeadMiningRequestResCountryStateRel> CrmIapLeadMiningRequestResCountryStateRels { get; } = new List<CrmIapLeadMiningRequestResCountryStateRel>();

    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
