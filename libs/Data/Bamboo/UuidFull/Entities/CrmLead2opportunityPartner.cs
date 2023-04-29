using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_lead2opportunity_partner")]
public partial class CrmLead2opportunityPartner
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

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmLead2opportunityPartnerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LeadId")]
    [InverseProperty("CrmLead2opportunityPartners")]
    public virtual CrmLead? Lead { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("CrmLead2opportunityPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("CrmLead2opportunityPartners")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmLead2opportunityPartnerUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmLead2opportunityPartnerWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CrmLead2opportunityPartnerId")]
    [InverseProperty("CrmLead2opportunityPartnersNavigation")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();
}
