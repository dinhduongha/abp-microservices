using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrExpenseSplitWizard
{
    public Guid Id { get; set; }

    public Guid? ExpenseId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrExpense? Expense { get; set; }

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    public virtual ResUser? WriteU { get; set; }
}
