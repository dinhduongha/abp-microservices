using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_analytic_applicability")]
public partial class AccountAnalyticApplicability
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("analytic_plan_id")]
    public Guid? AnalyticPlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("business_domain")]
    public string? BusinessDomain { get; set; }

    [Column("applicability")]
    public string? Applicability { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("product_categ_id")]
    public long? ProductCategId { get; set; }

    [Column("account_prefix")]
    public string? AccountPrefix { get; set; }

    [ForeignKey("AnalyticPlanId")]
    [InverseProperty("AccountAnalyticApplicabilities")]
    public virtual AccountAnalyticPlan? AnalyticPlan { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAnalyticApplicabilityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAnalyticApplicabilityWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
