using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_lead2opportunity_partner_mass")]
public partial class CrmLead2opportunityPartnerMass
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("lead_id")]
    public Guid? LeadId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("action")]
    public string? Action { get; set; }

    [Column("force_assignment")]
    public bool? ForceAssignment { get; set; }

    [Column("deduplicate")]
    public bool? Deduplicate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmLead2opportunityPartnerMassCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LeadId")]
    [InverseProperty("CrmLead2opportunityPartnerMassesNavigation")]
    public virtual CrmLead? Lead { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("CrmLead2opportunityPartnerMasses")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("CrmLead2opportunityPartnerMasses")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmLead2opportunityPartnerMassUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmLead2opportunityPartnerMassWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CrmLead2opportunityPartnerMassId")]
    [InverseProperty("CrmLead2opportunityPartnerMasses")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [ForeignKey("CrmLead2opportunityPartnerMassId")]
    [InverseProperty("CrmLead2opportunityPartnerMasses1")]
    public virtual ICollection<CrmLead> CrmLeadsNavigation { get; } = new List<CrmLead>();

    [ForeignKey("CrmLead2opportunityPartnerMassId")]
    [InverseProperty("CrmLead2opportunityPartnerMasses")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
