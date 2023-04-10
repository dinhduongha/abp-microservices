using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrExpenseSplit
{
    public Guid Id { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? ExpenseId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? AnalyticDistribution { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? ProductHasCost { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SaleOrderId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual HrExpense? Expense { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual HrExpenseSplitWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
