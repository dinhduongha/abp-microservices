using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrExpenseApproveDuplicate
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();
}
