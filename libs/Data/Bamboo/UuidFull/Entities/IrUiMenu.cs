﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_ui_menu")]
[Index("ParentId", Name = "ir_ui_menu_parent_id_index")]
[Index("ParentPath", Name = "ir_ui_menu_parent_path_index")]
public partial class IrUiMenu
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("web_icon")]
    public string? WebIcon { get; set; }

    [Column("action")]
    public string? Action { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrUiMenuCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<IrUiMenu> InverseParent { get; } = new List<IrUiMenu>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual IrUiMenu? Parent { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreates { get; } = new List<WizardIrModelMenuCreate>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrUiMenuWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("Menus")]
    public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();
}
