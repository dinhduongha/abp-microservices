using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crossovered_budget_lines")]
[Index("CrossoveredBudgetId", Name = "crossovered_budget_lines_crossovered_budget_id_index")]
public partial class CrossoveredBudgetLine
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
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

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
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AnalyticAccountId")]
    [InverseProperty("CrossoveredBudgetLines")]
    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("CrossoveredBudgetLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrossoveredBudgetLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CrossoveredBudgetId")]
    [InverseProperty("CrossoveredBudgetLines")]
    public virtual CrossoveredBudget? CrossoveredBudget { get; set; }

    [ForeignKey("GeneralBudgetId")]
    [InverseProperty("CrossoveredBudgetLines")]
    public virtual AccountBudgetPost? GeneralBudget { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrossoveredBudgetLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
