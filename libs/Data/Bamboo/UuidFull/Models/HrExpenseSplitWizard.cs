using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrExpenseSplitWizard
{
    public Guid Id { get; set; }

    public Guid? ExpenseId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrExpense? Expense { get; set; }

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    public virtual ResUser? WriteU { get; set; }
}
