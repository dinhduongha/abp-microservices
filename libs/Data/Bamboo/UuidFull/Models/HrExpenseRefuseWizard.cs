using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrExpenseRefuseWizard
{
    public Guid Id { get; set; }

    public Guid? HrExpenseSheetId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Reason { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrExpenseSheet? HrExpenseSheet { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();
}
