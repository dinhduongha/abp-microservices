using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrExpenseSheet
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? AddressId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? BankJournalId { get; set; }

    public Guid? AccountMoveId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? PaymentState { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? UntaxedAmount { get; set; }

    public decimal? TotalAmountTaxes { get; set; }

    public decimal? AmountResidual { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual AccountJournal? BankJournal { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    //public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; } = new List<HrExpenseRefuseWizard>();

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    public virtual AccountJournal? Journal { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; } = new List<HrExpenseApproveDuplicate>();
}
