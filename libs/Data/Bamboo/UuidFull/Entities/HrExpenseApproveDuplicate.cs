using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_expense_approve_duplicate")]
public partial class HrExpenseApproveDuplicate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrExpenseApproveDuplicateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrExpenseApproveDuplicateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrExpenseApproveDuplicateId")]
    [InverseProperty("HrExpenseApproveDuplicates")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    [ForeignKey("HrExpenseApproveDuplicateId")]
    [InverseProperty("HrExpenseApproveDuplicates")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();
}
