using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmTeam
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? UserId { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? UseQuotations { get; set; }

    public double? InvoicedTarget { get; set; }

    public Guid? AliasId { get; set; }

    public string? AssignmentDomain { get; set; }

    public string? LeadPropertiesDefinition { get; set; }

    public bool? UseLeads { get; set; }

    public bool? UseOpportunities { get; set; }

    public bool? AssignmentOptout { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual MailAlias? Alias { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; } = new List<CrmIapLeadMiningRequest>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencies { get; } = new List<CrmLeadScoringFrequency>();

    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunities { get; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<CrmStage> CrmStages { get; } = new List<CrmStage>();

    public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; } = new List<CrmTeamMember>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? User { get; set; }

    public virtual ICollection<Website> WebsiteCrmDefaultTeams { get; } = new List<Website>();

    public virtual ICollection<Website> WebsiteSalesteams { get; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
