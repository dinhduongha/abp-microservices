using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("EventId", "TypeId")]
[Table("meeting_category_rel")]
[Index("TypeId", "EventId", Name = "meeting_category_rel_type_id_event_id_idx")]
public partial class MeetingCategoryRel
{
    [Key]
    [Column("event_id")]
    public Guid EventId { get; set; }

    [Key]
    [Column("type_id")]
    public long TypeId { get; set; }

    [ForeignKey("EventId")]
    [InverseProperty("MeetingCategoryRels")]
    public virtual CalendarEvent Event { get; set; } = null!;
}
