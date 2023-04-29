using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_job")]
[Index("IsPublished", Name = "hr_job_is_published_index")]
[Index("Name", "CompanyId", "DepartmentId", Name = "hr_job_name_company_uniq", IsUnique = true)]
[Index("WebsiteId", Name = "hr_job_website_id_index")]
public partial class HrJob
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("expected_employees")]
    public long? ExpectedEmployees { get; set; }

    [Column("no_of_employee")]
    public long? NoOfEmployee { get; set; }

    [Column("no_of_recruitment")]
    public long? NoOfRecruitment { get; set; }

    [Column("no_of_hired_employee")]
    public long? NoOfHiredEmployee { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("contract_type_id")]
    public long? ContractTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("requirements")]
    public string? Requirements { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("alias_id")]
    public Guid? AliasId { get; set; }

    [Column("address_id")]
    public Guid? AddressId { get; set; }

    [Column("manager_id")]
    public Guid? ManagerId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("hr_responsible_id")]
    public Guid? HrResponsibleId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("website_meta_og_img")]
    public string? WebsiteMetaOgImg { get; set; }

    [Column("website_meta_title", TypeName = "jsonb")]
    public string? WebsiteMetaTitle { get; set; }

    [Column("website_meta_description", TypeName = "jsonb")]
    public string? WebsiteMetaDescription { get; set; }

    [Column("website_meta_keywords", TypeName = "jsonb")]
    public string? WebsiteMetaKeywords { get; set; }

    [Column("seo_name", TypeName = "jsonb")]
    public string? SeoName { get; set; }

    [Column("website_description", TypeName = "jsonb")]
    public string? WebsiteDescription { get; set; }

    [Column("job_details", TypeName = "jsonb")]
    public string? JobDetails { get; set; }

    [Column("is_published")]
    public bool? IsPublished { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("HrJobs")]
    public virtual ResPartner? Address { get; set; }

    [ForeignKey("AliasId")]
    [InverseProperty("HrJobs")]
    public virtual MailAlias? Alias { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrJobs")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrJobCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("HrJobs")]
    public virtual HrDepartment? Department { get; set; }

    [InverseProperty("Job")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [InverseProperty("Job")]
    public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    [InverseProperty("Job")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [InverseProperty("HrJob")]
    public virtual ICollection<HrJobHrRecruitmentStageRel> HrJobHrRecruitmentStageRels { get; } = new List<HrJobHrRecruitmentStageRel>();

    [InverseProperty("Job")]
    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; } = new List<HrRecruitmentSource>();

    [ForeignKey("HrResponsibleId")]
    [InverseProperty("HrJobHrResponsibles")]
    public virtual ResUser? HrResponsible { get; set; }

    [ForeignKey("ManagerId")]
    [InverseProperty("HrJobs")]
    public virtual HrEmployee? Manager { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("HrJobs")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("HrJobUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("HrJobs")]
    public virtual Website? Website { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrJobWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrJobId")]
    [InverseProperty("HrJobs")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    [ForeignKey("HrJobId")]
    [InverseProperty("HrJobsNavigation")]
    public virtual ICollection<ResUser> ResUsersNavigation { get; } = new List<ResUser>();

    [ForeignKey("JobId")]
    [InverseProperty("Jobs")]
    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
