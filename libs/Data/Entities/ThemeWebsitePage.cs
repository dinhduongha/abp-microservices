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

[Table("theme_website_page")]
public partial class ThemeWebsitePage
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("view_id")]
    public long? ViewId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("header_color")]
    public string? HeaderColor { get; set; }

    [Column("website_indexed")]
    public bool? WebsiteIndexed { get; set; }

    [Column("is_published")]
    public bool? IsPublished { get; set; }

    [Column("header_overlay")]
    public bool? HeaderOverlay { get; set; }

    [Column("header_visible")]
    public bool? HeaderVisible { get; set; }

    [Column("footer_visible")]
    public bool? FooterVisible { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ThemeWebsitePageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Page")]
    public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenus { get; } = new List<ThemeWebsiteMenu>();

    [ForeignKey("ViewId")]
    [InverseProperty("ThemeWebsitePages")]
    public virtual ThemeIrUiView? View { get; set; }

    [InverseProperty("ThemeTemplate")]
    public virtual ICollection<WebsitePage> WebsitePages { get; } = new List<WebsitePage>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("ThemeWebsitePageWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
