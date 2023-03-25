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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("CrmMergeOpportunityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("CrmMergeOpportunities")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmMergeOpportunityUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("CrmMergeOpportunityWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MergeId")]
    [InverseProperty("Merges")]
    public virtual ICollection<CrmLead> Opportunities { get; } = new List<CrmLead>();
}
