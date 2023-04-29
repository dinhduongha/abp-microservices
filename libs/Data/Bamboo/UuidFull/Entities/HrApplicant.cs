﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_applicant")]
[Index("DateLastStageUpdate", Name = "hr_applicant_date_last_stage_update_index")]
[Index("JobId", Name = "hr_applicant_job_id_index")]
[Index("StageId", Name = "hr_applicant_stage_id_index")]
public partial class HrApplicant
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("campaign_id")]
    public Guid? CampaignId { get; set; }

    [Column("source_id")]
    public Guid? SourceId { get; set; }

    [Column("medium_id")]
    public Guid? MediumId { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("stage_id")]
    public long? StageId { get; set; }

    [Column("last_stage_id")]
    public long? LastStageId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("job_id")]
    public Guid? JobId { get; set; }

    [Column("type_id")]
    public long? TypeId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("emp_id")]
    public Guid? EmpId { get; set; }

    [Column("refuse_reason_id")]
    public Guid? RefuseReasonId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email_cc")]
    public string? EmailCc { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("email_from")]
    public string? EmailFrom { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("salary_proposed_extra")]
    public string? SalaryProposedExtra { get; set; }

    [Column("salary_expected_extra")]
    public string? SalaryExpectedExtra { get; set; }

    [Column("partner_name")]
    public string? PartnerName { get; set; }

    [Column("partner_phone")]
    public string? PartnerPhone { get; set; }

    [Column("partner_mobile")]
    public string? PartnerMobile { get; set; }

    [Column("kanban_state")]
    public string? KanbanState { get; set; }

    [Column("linkedin_profile")]
    public string? LinkedinProfile { get; set; }

    [Column("availability")]
    public DateOnly? Availability { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("date_closed", TypeName = "timestamp without time zone")]
    public DateTime? DateClosed { get; set; }

    [Column("date_open", TypeName = "timestamp without time zone")]
    public DateTime? DateOpen { get; set; }

    [Column("date_last_stage_update", TypeName = "timestamp without time zone")]
    public DateTime? DateLastStageUpdate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("probability")]
    public double? Probability { get; set; }

    [Column("salary_proposed")]
    public double? SalaryProposed { get; set; }

    [Column("salary_expected")]
    public double? SalaryExpected { get; set; }

    [Column("delay_close")]
    public double? DelayClose { get; set; }

    [InverseProperty("Applicant")]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    [ForeignKey("CampaignId")]
    [InverseProperty("HrApplicants")]
    public virtual UtmCampaign? Campaign { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrApplicants")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrApplicantCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("HrApplicants")]
    public virtual HrDepartment? Department { get; set; }

    [ForeignKey("EmpId")]
    [InverseProperty("HrApplicants")]
    public virtual HrEmployee? Emp { get; set; }

    [InverseProperty("HrApplicant")]
    public virtual ICollection<HrApplicantHrApplicantCategoryRel> HrApplicantHrApplicantCategoryRels { get; } = new List<HrApplicantHrApplicantCategoryRel>();

    [InverseProperty("Applicant")]
    public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; } = new List<HrApplicantSkill>();

    [ForeignKey("JobId")]
    [InverseProperty("HrApplicants")]
    public virtual HrJob? Job { get; set; }

    [ForeignKey("MediumId")]
    [InverseProperty("HrApplicants")]
    public virtual UtmMedium? Medium { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("HrApplicants")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("HrApplicants")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("RefuseReasonId")]
    [InverseProperty("HrApplicants")]
    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    [ForeignKey("SourceId")]
    [InverseProperty("HrApplicants")]
    public virtual UtmSource? Source { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("HrApplicantUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrApplicantWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrApplicantId")]
    [InverseProperty("HrApplicants")]
    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    [ForeignKey("HrApplicantId")]
    [InverseProperty("HrApplicants")]
    public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; } = new List<ApplicantSendMail>();

    [ForeignKey("HrApplicantId")]
    [InverseProperty("HrApplicants")]
    public virtual ICollection<HrSkill> HrSkills { get; } = new List<HrSkill>();

    [ForeignKey("HrApplicantId")]
    [InverseProperty("HrApplicants")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
