using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("hr_plan_activity_type")]
public partial class HrPlanActivityType: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("activity_type_id")]
    public long? ActivityTypeId { get; set; }

    [Column("responsible_id")]
    public Guid? ResponsibleId { get; set; }

    [Column("plan_id")]
    public Guid? PlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("responsible")]
    public string? Responsible { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("ActivityTypeId")]
    [InverseProperty("HrPlanActivityTypes")]
    public virtual MailActivityType? ActivityType { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("HrPlanActivityTypes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("HrPlanActivityTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PlanId")]
    //[InverseProperty("HrPlanActivityTypes")]
    public virtual HrPlan? Plan { get; set; }

    [ForeignKey("ResponsibleId")]
    //[InverseProperty("HrPlanActivityTypeResponsibleNavigations")]
    public virtual ResUser? ResponsibleNavigation { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("HrPlanActivityTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
