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

[Table("hr_plan_wizard")]
public partial class HrPlanWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("plan_id")]
    public Guid? PlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrPlanWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("HrPlanWizards")]
    public virtual HrPlan? Plan { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrPlanWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Employees")]
    public virtual ICollection<HrEmployee> PlanWizards { get; } = new List<HrEmployee>();
}
