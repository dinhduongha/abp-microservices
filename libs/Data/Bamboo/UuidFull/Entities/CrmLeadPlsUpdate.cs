using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_lead_pls_update")]
public partial class CrmLeadPlsUpdate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("pls_start_date")]
    public DateOnly? PlsStartDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmLeadPlsUpdateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmLeadPlsUpdateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CrmLeadPlsUpdateId")]
    [InverseProperty("CrmLeadPlsUpdates")]
    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFields { get; } = new List<CrmLeadScoringFrequencyField>();
}
