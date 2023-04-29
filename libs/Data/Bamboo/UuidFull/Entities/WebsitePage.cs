﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("website_page")]
[Index("IsPublished", Name = "website_page_is_published_index")]
[Index("WebsiteId", Name = "website_page_website_id_index")]
public partial class WebsitePage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("view_id")]
    public Guid? ViewId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("theme_template_id")]
    public long? ThemeTemplateId { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("header_color")]
    public string? HeaderColor { get; set; }

    [Column("is_published")]
    public bool? IsPublished { get; set; }

    [Column("website_indexed")]
    public bool? WebsiteIndexed { get; set; }

    [Column("header_overlay")]
    public bool? HeaderOverlay { get; set; }

    [Column("header_visible")]
    public bool? HeaderVisible { get; set; }

    [Column("footer_visible")]
    public bool? FooterVisible { get; set; }

    [Column("date_publish", TypeName = "timestamp without time zone")]
    public DateTime? DatePublish { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebsitePageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ViewId")]
    [InverseProperty("WebsitePages")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("WebsitePages")]
    public virtual Website? Website { get; set; }

    [InverseProperty("Page")]
    public virtual ICollection<WebsiteMenu> WebsiteMenus { get; } = new List<WebsiteMenu>();

    [InverseProperty("Page")]
    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    [ForeignKey("WriteUid")]
    [InverseProperty("WebsitePageWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
