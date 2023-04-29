﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_lead_scoring_frequency_field")]
public partial class CrmLeadScoringFrequencyField
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("field_id")]
    public Guid? FieldId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmLeadScoringFrequencyFieldCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FieldId")]
    [InverseProperty("CrmLeadScoringFrequencyFields")]
    public virtual IrModelField? Field { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmLeadScoringFrequencyFieldWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CrmLeadScoringFrequencyFieldId")]
    [InverseProperty("CrmLeadScoringFrequencyFields")]
    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdates { get; } = new List<CrmLeadPlsUpdate>();
}
