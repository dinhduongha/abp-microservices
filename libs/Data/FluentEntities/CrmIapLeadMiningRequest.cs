using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

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

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? SearchType { get; set; }

    public string? ErrorType { get; set; }

    public string? LeadType { get; set; }

    public string? ContactFilterType { get; set; }

    public bool? FilterOnSize { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    public virtual CrmIapLeadRole? PreferredRole { get; set; }

    public virtual CrmIapLeadSeniority? Seniority { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustries { get; } = new List<CrmIapLeadIndustry>();

    //public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoles { get; } = new List<CrmIapLeadRole>();

    //public virtual ICollection<CrmTag> CrmTags { get; } = new List<CrmTag>();

    //public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();

    //public virtual ICollection<ResCountryState> ResCountryStates { get; } = new List<ResCountryState>();
}
