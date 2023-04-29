using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("utm_campaign")]
[Index("Name", Name = "utm_campaign_unique_name", IsUnique = true)]
public partial class UtmCampaign
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("stage_id")]
    public long? StageId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("title", TypeName = "jsonb")]
    public string? Title { get; set; }

    [Column("is_auto_campaign")]
    public bool? IsAutoCampaign { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [InverseProperty("Campaign")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("CompanyId")]
    [InverseProperty("UtmCampaigns")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("UtmCampaignCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Campaign")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [InverseProperty("Campaign")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [InverseProperty("Campaign")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("UserId")]
    [InverseProperty("UtmCampaignUsers")]
    public virtual ResUser? User { get; set; }

    [InverseProperty("Tag")]
    public virtual ICollection<UtmTagRel> UtmTagRels { get; } = new List<UtmTagRel>();

    [ForeignKey("WriteUid")]
    [InverseProperty("UtmCampaignWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
