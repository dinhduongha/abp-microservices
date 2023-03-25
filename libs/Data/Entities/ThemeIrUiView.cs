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

[Table("theme_ir_ui_view")]
public partial class ThemeIrUiView
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

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
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ThemeIrUiViewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ThemeTemplate")]
    [NotMapped]
    public virtual ICollection<IrUiView> IrUiViews { get; } = new List<IrUiView>();

    [InverseProperty("View")]
    [NotMapped]
    public virtual ICollection<ThemeWebsitePage> ThemeWebsitePages { get; } = new List<ThemeWebsitePage>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("ThemeIrUiViewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
