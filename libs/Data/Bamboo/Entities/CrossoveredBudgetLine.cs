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

[Table("crossovered_budget_lines")]
[Index("CrossoveredBudgetId", Name = "crossovered_budget_lines_crossovered_budget_id_index")]
public partial class CrossoveredBudgetLine: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("crossovered_budget_id")]
    public Guid? CrossoveredBudgetId { get; set; }

    [Column("analytic_account_id")]
    public Guid? AnalyticAccountId { get; set; }

    [Column("general_budget_id")]
    public Guid? GeneralBudgetId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("crossovered_budget_state")]
    public string? CrossoveredBudgetState { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("paid_date")]
    public DateOnly? PaidDate { get; set; }

    [Column("planned_amount")]
    public decimal? PlannedAmount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AnalyticAccountId")]
    //[InverseProperty("CrossoveredBudgetLines")]
    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("CrossoveredBudgetLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CrossoveredBudgetLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CrossoveredBudgetId")]
    //[InverseProperty("CrossoveredBudgetLines")]
    public virtual CrossoveredBudget? CrossoveredBudget { get; set; }

    [ForeignKey("GeneralBudgetId")]
    //[InverseProperty("CrossoveredBudgetLines")]
    public virtual AccountBudgetPost? GeneralBudget { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CrossoveredBudgetLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
