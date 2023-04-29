using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("variable")]
    public string? Variable { get; set; }

    [Column("value")]
    public string? Value { get; set; }

    [Column("won_count")]
    public decimal? WonCount { get; set; }

    [Column("lost_count")]
    public decimal? LostCount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmLeadScoringFrequencyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("CrmLeadScoringFrequencies")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmLeadScoringFrequencyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
