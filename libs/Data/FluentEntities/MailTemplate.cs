using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailTemplate
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? ReportTemplate { get; set; }

    public Guid? MailServerId { get; set; }

    public Guid? RefIrActWindow { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? TemplateFs { get; set; }

    public string? Lang { get; set; }

    public string? Model { get; set; }

    public string? EmailFrom { get; set; }

    public string? EmailTo { get; set; }

    public string? PartnerTo { get; set; }

    public string? EmailCc { get; set; }

    public string? ReplyTo { get; set; }

    public string? ScheduledDate { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Subject { get; set; }

    public string? BodyHtml { get; set; }

    public string? ReportName { get; set; }

    public bool? Active { get; set; }

    public bool? UseDefaultTo { get; set; }

    public bool? AutoDelete { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; } = new List<AccountInvoiceSend>();

    //public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    //public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; } = new List<ApplicantSendMail>();

    //public virtual ICollection<CalendarAlarm> CalendarAlarms { get; } = new List<CalendarAlarm>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<FollowupLine> FollowupLines { get; } = new List<FollowupLine>();

    //public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasons { get; } = new List<HrApplicantRefuseReason>();

    //public virtual ICollection<HrRecruitmentStage> HrRecruitmentStages { get; } = new List<HrRecruitmentStage>();

    //public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    public virtual IrMailServer? MailServer { get; set; }

    //public virtual ICollection<MailTemplatePreview> MailTemplatePreviews { get; } = new List<MailTemplatePreview>();

    public virtual IrModel? ModelNavigation { get; set; }

    //public virtual ICollection<ProjectProjectStage> ProjectProjectStages { get; } = new List<ProjectProjectStage>();

    //public virtual ICollection<ProjectTaskType> ProjectTaskTypeMailTemplates { get; } = new List<ProjectTaskType>();

    //public virtual ICollection<ProjectTaskType> ProjectTaskTypeRatingTemplates { get; } = new List<ProjectTaskType>();

    public virtual IrActWindow? RefIrActWindowNavigation { get; set; }

    public virtual IrActReportXml? ReportTemplateNavigation { get; set; }

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; } = new List<SaleOrderCancel>();

    //public virtual ICollection<SaleOrderTemplate> SaleOrderTemplates { get; } = new List<SaleOrderTemplate>();

    //public virtual ICollection<Website> Websites { get; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrAttachment> Attachments { get; } = new List<IrAttachment>();

    //public virtual ICollection<MailActivityType> MailActivityTypes { get; } = new List<MailActivityType>();

    //public virtual ICollection<MailTemplateReset> MailTemplateResets { get; } = new List<MailTemplateReset>();
}
