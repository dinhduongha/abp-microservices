using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrActServer
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

    public long Sequence { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? CrudModelId { get; set; }

    public Guid? LinkFieldId { get; set; }

    public string? Usage { get; set; }

    public string? State { get; set; }

    public string? ModelName { get; set; }

    public string? Code { get; set; }

    public Guid? TemplateId { get; set; }

    public long? ActivityTypeId { get; set; }

    public long? ActivityDateDeadlineRange { get; set; }

    public Guid? ActivityUserId { get; set; }

    public string? MailPostMethod { get; set; }

    public string? ActivitySummary { get; set; }

    public string? ActivityDateDeadlineRangeType { get; set; }

    public string? ActivityUserType { get; set; }

    public string? ActivityUserFieldName { get; set; }

    public string? ActivityNote { get; set; }

    public bool? MailPostAutofollow { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public string? SmsMethod { get; set; }

    public string? WebsitePath { get; set; }

    public bool? WebsitePublished { get; set; }

    public virtual MailActivityType? ActivityType { get; set; }

    public virtual ResUser? ActivityUser { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? CrudModel { get; set; }

    //public virtual ICollection<IrCron> IrCrons { get; } = new List<IrCron>();

    //public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; } = new List<IrServerObjectLine>();

    public virtual IrModelField? LinkField { get; set; }

    public virtual IrModel? Model { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual MailTemplate? Template { get; set; }

    //public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; } = new List<WebsiteSnippetFilter>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrActServer> Actions { get; } = new List<IrActServer>();

    //public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<IrActServer> Servers { get; } = new List<IrActServer>();
}
