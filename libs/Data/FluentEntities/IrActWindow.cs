using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrActWindow
{
    public Guid Id { get; set; }

    public Guid? BindingModelId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Type { get; set; }

    public string? BindingType { get; set; }

    public string? BindingViewTypes { get; set; }

    public string? Name { get; set; }

    public string? Help { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? ResId { get; set; }

    public Guid? Limit { get; set; }

    public Guid? SearchViewId { get; set; }

    public string? Domain { get; set; }

    public string? Context { get; set; }

    public string? ResModel { get; set; }

    public string? Target { get; set; }

    public string? ViewMode { get; set; }

    public string? Usage { get; set; }

    public bool? Filter { get; set; }

    //public virtual ICollection<AccountReportColumn> AccountReportColumns { get; } = new List<AccountReportColumn>();

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrActWindowView> IrActWindowViews { get; } = new List<IrActWindowView>();

    //public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    public virtual IrUiView? SearchView { get; set; }

    //public virtual ICollection<SmsTemplate> SmsTemplates { get; } = new List<SmsTemplate>();

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();
}
