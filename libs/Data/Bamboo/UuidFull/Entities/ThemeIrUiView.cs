using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("theme_ir_ui_view")]
public partial class ThemeIrUiView
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("key")]
    public string? Key { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("mode")]
    public string? Mode { get; set; }

    [Column("arch_fs")]
    public string? ArchFs { get; set; }

    [Column("inherit_id")]
    public string? InheritId { get; set; }

    [Column("arch", TypeName = "jsonb")]
    public string? Arch { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("customize_show")]
    public bool? CustomizeShow { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ThemeIrUiViewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ThemeIrUiViewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
