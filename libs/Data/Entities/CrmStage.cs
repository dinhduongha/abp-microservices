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

[Table("crm_stage")]
public partial class CrmStage
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("sequence", TypeName = "bigserial")]
    public long Sequence { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("requirements")]
    public string? Requirements { get; set; }

    [Column("is_won")]
    public bool? IsWon { get; set; }

    [Column("fold")]
    public bool? Fold { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CrmStageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TeamId")]
    //[InverseProperty("CrmStages")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CrmStageWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Stage")]
    [NotMapped]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

}
