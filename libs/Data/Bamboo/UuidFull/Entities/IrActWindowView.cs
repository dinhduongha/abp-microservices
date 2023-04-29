using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_act_window_view")]
[Index("ActWindowId", "ViewMode", Name = "act_window_view_unique_mode_per_action", IsUnique = true)]
public partial class IrActWindowView
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

    [Column("view_id")]
    public Guid? ViewId { get; set; }

    [Column("act_window_id")]
    public Guid? ActWindowId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("view_mode")]
    public string? ViewMode { get; set; }

    [Column("multi")]
    public bool? Multi { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("ActWindowId")]
    [InverseProperty("IrActWindowViews")]
    public virtual IrActWindow? ActWindow { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrActWindowViewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ViewId")]
    [InverseProperty("IrActWindowViewsNavigation")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrActWindowViewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
