using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrExpenseApproveDuplicate
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();
}
