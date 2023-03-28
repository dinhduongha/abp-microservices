using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrActReportXml
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

    public long? PaperformatId { get; set; }

    public string? Model { get; set; }

    public string? ReportType { get; set; }

    public string? ReportName { get; set; }

    public string? ReportFile { get; set; }

    public string? Attachment { get; set; }

    public string? PrintReportName { get; set; }

    public bool? Multi { get; set; }

    public bool? AttachmentUse { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    public virtual ReportPaperformat? Paperformat { get; set; }

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();
}
