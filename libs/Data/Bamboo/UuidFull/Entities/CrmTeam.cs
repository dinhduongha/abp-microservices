using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_team")]
[Index("CompanyId", Name = "crm_team_company_id_index")]
public partial class CrmTeam
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("use_quotations")]
    public bool? UseQuotations { get; set; }

    [Column("invoiced_target")]
    public double? InvoicedTarget { get; set; }

    [Column("alias_id")]
    public Guid? AliasId { get; set; }

    [Column("assignment_domain")]
    public string? AssignmentDomain { get; set; }

    [Column("lead_properties_definition", TypeName = "jsonb")]
    public string? LeadPropertiesDefinition { get; set; }

    [Column("use_leads")]
    public bool? UseLeads { get; set; }

    [Column("use_opportunities")]
    public bool? UseOpportunities { get; set; }

    [Column("assignment_optout")]
    public bool? AssignmentOptout { get; set; }

    [InverseProperty("Team")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("AliasId")]
    [InverseProperty("CrmTeams")]
    public virtual MailAlias? Alias { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("CrmTeams")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmTeamCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Team")]
    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; } = new List<CrmIapLeadMiningRequest>();

    [InverseProperty("Team")]
    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    [InverseProperty("Team")]
    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; } = new List<CrmLead2opportunityPartner>();

    [InverseProperty("Team")]
    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencies { get; } = new List<CrmLeadScoringFrequency>();

    [InverseProperty("Team")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [InverseProperty("Team")]
    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunities { get; } = new List<CrmMergeOpportunity>();

    [InverseProperty("Team")]
    public virtual ICollection<CrmStage> CrmStages { get; } = new List<CrmStage>();

    [InverseProperty("CrmTeam")]
    public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; } = new List<CrmTeamMember>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("CrmTeams")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [InverseProperty("CrmTeam")]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [InverseProperty("CrmTeam")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("Team")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [InverseProperty("SaleTeam")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    [InverseProperty("Team")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("UserId")]
    [InverseProperty("CrmTeamUsers")]
    public virtual ResUser? User { get; set; }

    [InverseProperty("CrmDefaultTeam")]
    public virtual ICollection<Website> WebsiteCrmDefaultTeams { get; } = new List<Website>();

    [InverseProperty("Salesteam")]
    public virtual ICollection<Website> WebsiteSalesteams { get; } = new List<Website>();

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmTeamWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("Teams")]
    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
