using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_merge_opportunity")]
public partial class CrmMergeOpportunity
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmMergeOpportunityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("CrmMergeOpportunities")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmMergeOpportunityUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmMergeOpportunityWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MergeId")]
    [InverseProperty("Merges")]
    public virtual ICollection<CrmLead> Opportunities { get; } = new List<CrmLead>();
}
