using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_expense_split")]
public partial class HrExpenseSplit
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("expense_id")]
    public Guid? ExpenseId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("total_amount")]
    public decimal? TotalAmount { get; set; }

    [Column("product_has_cost")]
    public bool? ProductHasCost { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_order_id")]
    public Guid? SaleOrderId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrExpenseSplitCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("ExpenseId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual HrExpense? Expense { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("SaleOrderId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual SaleOrder? SaleOrder { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual HrExpenseSplitWizard? Wizard { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrExpenseSplitWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrExpenseSplitId")]
    [InverseProperty("HrExpenseSplits")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
