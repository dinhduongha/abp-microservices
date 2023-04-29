﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("calendar_event_type")]
[Index("Name", Name = "calendar_event_type_name_uniq", IsUnique = true)]
public partial class CalendarEventType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CalendarEventTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CalendarEventTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
