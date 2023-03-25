using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("crm_iap_lead_mining_request")]
public partial class CrmIapLeadMiningRequest
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("lead_number")]
    public long? LeadNumber { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_size_min")]
    public long? CompanySizeMin { get; set; }

    [Column("company_size_max")]
    public long? CompanySizeMax { get; set; }

    [Column("contact_number")]
    public long? ContactNumber { get; set; }

    [Column("preferred_role_id")]
    public long? PreferredRoleId { get; set; }

    [Column("seniority_id")]
    public long? SeniorityId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("search_type")]
    public string? SearchType { get; set; }

    [Column("error_type")]
    public string? ErrorType { get; set; }

    [Column("lead_type")]
    public string? LeadType { get; set; }

    [Column("contact_filter_type")]
    public string? ContactFilterType { get; set; }

    [Column("filter_on_size")]
    public bool? FilterOnSize { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("CrmIapLeadMiningRequestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("LeadMiningRequest")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [ForeignKey("PreferredRoleId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual CrmIapLeadRole? PreferredRole { get; set; }

    [ForeignKey("SeniorityId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual CrmIapLeadSeniority? Seniority { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmIapLeadMiningRequestUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("CrmIapLeadMiningRequestWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustries { get; } = new List<CrmIapLeadIndustry>();

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequestsNavigation")]
    public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoles { get; } = new List<CrmIapLeadRole>();

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual ICollection<CrmTag> CrmTags { get; } = new List<CrmTag>();

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual ICollection<ResCountryState> ResCountryStates { get; } = new List<ResCountryState>();
}
