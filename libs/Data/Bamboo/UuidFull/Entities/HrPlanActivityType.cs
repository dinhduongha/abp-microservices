using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_plan_activity_type")]
public partial class HrPlanActivityType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("activity_type_id")]
    public long? ActivityTypeId { get; set; }

    [Column("responsible_id")]
    public Guid? ResponsibleId { get; set; }

    [Column("plan_id")]
    public Guid? PlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("responsible")]
    public string? Responsible { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrPlanActivityTypes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrPlanActivityTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("HrPlanActivityTypes")]
    public virtual HrPlan? Plan { get; set; }

    [ForeignKey("ResponsibleId")]
    [InverseProperty("HrPlanActivityTypeResponsibleNavigations")]
    public virtual ResUser? ResponsibleNavigation { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrPlanActivityTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
