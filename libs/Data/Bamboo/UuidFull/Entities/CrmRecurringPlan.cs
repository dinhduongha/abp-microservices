using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_recurring_plan")]
public partial class CrmRecurringPlan
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("number_of_months")]
    public long? NumberOfMonths { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmRecurringPlanCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RecurringPlanNavigation")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmRecurringPlanWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
