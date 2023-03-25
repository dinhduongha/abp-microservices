using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("hr_expense_split_wizard")]
public partial class HrExpenseSplitWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("expense_id")]
    public Guid? ExpenseId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrExpenseSplitWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ExpenseId")]
    [InverseProperty("HrExpenseSplitWizards")]
    public virtual HrExpense? Expense { get; set; }

    [InverseProperty("Wizard")]
    [NotMapped]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrExpenseSplitWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
