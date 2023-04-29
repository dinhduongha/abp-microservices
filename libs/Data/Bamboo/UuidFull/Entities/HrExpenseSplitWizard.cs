using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_expense_split_wizard")]
public partial class HrExpenseSplitWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("expense_id")]
    public Guid? ExpenseId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrExpenseSplitWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ExpenseId")]
    [InverseProperty("HrExpenseSplitWizards")]
    public virtual HrExpense? Expense { get; set; }

    [InverseProperty("Wizard")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [ForeignKey("WriteUid")]
    [InverseProperty("HrExpenseSplitWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
