using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

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
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmIapLeadMiningRequestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("CrmIapLeadMiningRequest")]
    public virtual ICollection<CrmIapLeadIndustryCrmIapLeadMiningRequestRel> CrmIapLeadIndustryCrmIapLeadMiningRequestRels { get; } = new List<CrmIapLeadIndustryCrmIapLeadMiningRequestRel>();

    [InverseProperty("CrmIapLeadMiningRequest")]
    public virtual ICollection<CrmIapLeadMiningRequestCrmIapLeadRoleRel> CrmIapLeadMiningRequestCrmIapLeadRoleRels { get; } = new List<CrmIapLeadMiningRequestCrmIapLeadRoleRel>();

    [InverseProperty("CrmIapLeadMiningRequest")]
    public virtual ICollection<CrmIapLeadMiningRequestCrmTagRel> CrmIapLeadMiningRequestCrmTagRels { get; } = new List<CrmIapLeadMiningRequestCrmTagRel>();

    [InverseProperty("CrmIapLeadMiningRequest")]
    public virtual ICollection<CrmIapLeadMiningRequestResCountryRel> CrmIapLeadMiningRequestResCountryRels { get; } = new List<CrmIapLeadMiningRequestResCountryRel>();

    [InverseProperty("CrmIapLeadMiningRequest")]
    public virtual ICollection<CrmIapLeadMiningRequestResCountryStateRel> CrmIapLeadMiningRequestResCountryStateRels { get; } = new List<CrmIapLeadMiningRequestResCountryStateRel>();

    [InverseProperty("LeadMiningRequest")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [ForeignKey("TeamId")]
    [InverseProperty("CrmIapLeadMiningRequests")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmIapLeadMiningRequestUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmIapLeadMiningRequestWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
