using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrExpenseSplit
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? ExpenseId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? AnalyticDistribution { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? ProductHasCost { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SaleOrderId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual HrExpense? Expense { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual HrExpenseSplitWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
