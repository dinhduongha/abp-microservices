using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrApplicant
{
    public Guid Id { get; set; }

    public Guid? CampaignId { get; set; }

    public Guid? SourceId { get; set; }

    public Guid? MediumId { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? PartnerId { get; set; }

    public long? StageId { get; set; }

    public long? LastStageId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? JobId { get; set; }

    public long? TypeId { get; set; }

    public Guid? DepartmentId { get; set; }

    public long? Color { get; set; }

    public Guid? EmpId { get; set; }

    public Guid? RefuseReasonId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? EmailCc { get; set; }

    public string? Name { get; set; }

    public string? EmailFrom { get; set; }

    public string? Priority { get; set; }

    public string? SalaryProposedExtra { get; set; }

    public string? SalaryExpectedExtra { get; set; }

    public string? PartnerName { get; set; }

    public string? PartnerPhone { get; set; }

    public string? PartnerMobile { get; set; }

    public string? KanbanState { get; set; }

    public string? LinkedinProfile { get; set; }

    public DateOnly? Availability { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? DateClosed { get; set; }

    public DateTime? DateOpen { get; set; }

    public DateTime? DateLastStageUpdate { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Probability { get; set; }

    public double? SalaryProposed { get; set; }

    public double? SalaryExpected { get; set; }

    public double? DelayClose { get; set; }

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Emp { get; set; }

    //public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; } = new List<HrApplicantSkill>();

    public virtual HrJob? Job { get; set; }

    public virtual HrRecruitmentStage? LastStage { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual HrRecruitmentStage? Stage { get; set; }

    public virtual HrRecruitmentDegree? Type { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    //public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; } = new List<ApplicantSendMail>();

    //public virtual ICollection<HrApplicantCategory> HrApplicantCategories { get; } = new List<HrApplicantCategory>();

    //public virtual ICollection<HrSkill> HrSkills { get; } = new List<HrSkill>();

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
