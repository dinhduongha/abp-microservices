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

[Table("crm_lead_scoring_frequency")]
[Index("Variable", Name = "crm_lead_scoring_frequency_variable_index")]
public partial class CrmLeadScoringFrequency
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("variable")]
    public string? Variable { get; set; }

    [Column("value")]
    public string? Value { get; set; }

    [Column("won_count")]
    public decimal? WonCount { get; set; }

    [Column("lost_count")]
    public decimal? LostCount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CrmLeadScoringFrequencyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TeamId")]
    //[InverseProperty("CrmLeadScoringFrequencies")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CrmLeadScoringFrequencyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
