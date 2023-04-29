using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_plan")]
public partial class HrPlan
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrPlans")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrPlanCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("HrPlans")]
    public virtual HrDepartment? Department { get; set; }

    [InverseProperty("Plan")]
    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; } = new List<HrPlanActivityType>();

    [InverseProperty("Plan")]
    public virtual ICollection<HrPlanWizard> HrPlanWizards { get; } = new List<HrPlanWizard>();

    [ForeignKey("WriteUid")]
    [InverseProperty("HrPlanWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
