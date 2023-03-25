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

[Table("hr_expense_sheet")]
[Index("State", Name = "hr_expense_sheet_state_index")]
public partial class HrExpenseSheet: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("address_id")]
    public Guid? AddressId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("bank_journal_id")]
    public Guid? BankJournalId { get; set; }

    [Column("account_move_id")]
    public Guid? AccountMoveId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("payment_state")]
    public string? PaymentState { get; set; }

    [Column("accounting_date")]
    public DateOnly? AccountingDate { get; set; }

    [Column("total_amount")]
    public decimal? TotalAmount { get; set; }

    [Column("untaxed_amount")]
    public decimal? UntaxedAmount { get; set; }

    [Column("total_amount_taxes")]
    public decimal? TotalAmountTaxes { get; set; }

    [Column("amount_residual")]
    public decimal? AmountResidual { get; set; }

    [Column("approval_date", TypeName = "timestamp without time zone")]
    public DateTime? ApprovalDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AccountMoveId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual AccountMove? AccountMove { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual ResPartner? Address { get; set; }

    [ForeignKey("BankJournalId")]
    [InverseProperty("HrExpenseSheetBankJournals")]
    public virtual AccountJournal? BankJournal { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrExpenseSheetCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual HrDepartment? Department { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual HrEmployee? Employee { get; set; }

    [InverseProperty("HrExpenseSheet")]
    [NotMapped]
    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; } = new List<HrExpenseRefuseWizard>();

    [InverseProperty("Sheet")]
    [NotMapped]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [ForeignKey("JournalId")]
    [InverseProperty("HrExpenseSheetJournals")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("HrExpenseSheets")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("HrExpenseSheetUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrExpenseSheetWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrExpenseSheetId")]
    [InverseProperty("HrExpenseSheets")]
    [NotMapped]
    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; } = new List<HrExpenseApproveDuplicate>();
}
