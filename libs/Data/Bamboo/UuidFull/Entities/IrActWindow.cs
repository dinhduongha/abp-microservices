using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_act_window")]
public partial class IrActWindow
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("binding_model_id")]
    public Guid? BindingModelId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("binding_type")]
    public string? BindingType { get; set; }

    [Column("binding_view_types")]
    public string? BindingViewTypes { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("help", TypeName = "jsonb")]
    public string? Help { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("view_id")]
    public Guid? ViewId { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("limit")]
    public Guid? Limit { get; set; }

    [Column("search_view_id")]
    public Guid? SearchViewId { get; set; }

    [Column("domain")]
    public string? Domain { get; set; }

    [Column("context")]
    public string? Context { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("target")]
    public string? Target { get; set; }

    [Column("view_mode")]
    public string? ViewMode { get; set; }

    [Column("usage")]
    public string? Usage { get; set; }

    [Column("filter")]
    public bool? Filter { get; set; }

    [InverseProperty("CustomAuditAction")]
    public virtual ICollection<AccountReportColumn> AccountReportColumns { get; } = new List<AccountReportColumn>();

    [ForeignKey("BindingModelId")]
    [InverseProperty("IrActWindows")]
    public virtual IrModel? BindingModel { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrActWindowCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ActWindow")]
    public virtual ICollection<IrActWindowView> IrActWindowViews { get; } = new List<IrActWindowView>();

    [InverseProperty("RefIrActWindowNavigation")]
    public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    [ForeignKey("SearchViewId")]
    [InverseProperty("IrActWindowSearchViews")]
    public virtual IrUiView? SearchView { get; set; }

    [InverseProperty("SidebarAction")]
    public virtual ICollection<SmsTemplate> SmsTemplates { get; } = new List<SmsTemplate>();

    [ForeignKey("ViewId")]
    [InverseProperty("IrActWindowViews")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrActWindowWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ActId")]
    [InverseProperty("ActsNavigation")]
    public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();
}
