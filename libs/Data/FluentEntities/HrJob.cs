using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrJob
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long Sequence { get; set; }

    public long? ExpectedEmployees { get; set; }

    public long? NoOfEmployee { get; set; }

    public long? NoOfRecruitment { get; set; }

    public long? NoOfHiredEmployee { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? TenantId { get; set; }

    public long? ContractTypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Requirements { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? AliasId { get; set; }

    public Guid? AddressId { get; set; }

    public Guid? ManagerId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? HrResponsibleId { get; set; }

    public long? Color { get; set; }

    public Guid? WebsiteId { get; set; }

    public string? WebsiteMetaOgImg { get; set; }

    public string? WebsiteMetaTitle { get; set; }

    public string? WebsiteMetaDescription { get; set; }

    public string? WebsiteMetaKeywords { get; set; }

    public string? SeoName { get; set; }

    public string? WebsiteDescription { get; set; }

    public string? JobDetails { get; set; }

    public bool? IsPublished { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual MailAlias? Alias { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual HrContractType? ContractType { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    //public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; } = new List<HrRecruitmentSource>();

    public virtual ResUser? HrResponsible { get; set; }

    public virtual HrEmployee? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrRecruitmentStage> HrRecruitmentStages { get; } = new List<HrRecruitmentStage>();

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    //public virtual ICollection<ResUser> ResUsersNavigation { get; } = new List<ResUser>();

    //public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
