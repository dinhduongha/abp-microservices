using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_plan_wizard")]
public partial class HrPlanWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("plan_id")]
    public Guid? PlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrPlanWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("HrPlanWizards")]
    public virtual HrPlan? Plan { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrPlanWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Employees")]
    public virtual ICollection<HrEmployee> PlanWizards { get; } = new List<HrEmployee>();
}
