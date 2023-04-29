using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("theme_website_menu")]
[Index("ParentId", Name = "theme_website_menu_parent_id_index")]
public partial class ThemeWebsiteMenu
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("page_id")]
    public long? PageId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("mega_menu_classes")]
    public string? MegaMenuClasses { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("mega_menu_content")]
    public string? MegaMenuContent { get; set; }

    [Column("new_window")]
    public bool? NewWindow { get; set; }

    [Column("use_main_menu_as_parent")]
    public bool? UseMainMenuAsParent { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ThemeWebsiteMenuCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ThemeWebsiteMenuWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
