using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrExpenseSheet
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? AddressId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? BankJournalId { get; set; }

    public Guid? AccountMoveId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? PaymentState { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? UntaxedAmount { get; set; }

    public decimal? TotalAmountTaxes { get; set; }

    public decimal? AmountResidual { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual AccountJournal? BankJournal { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; } = new List<HrExpenseRefuseWizard>();

    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    public virtual AccountJournal? Journal { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; } = new List<HrExpenseApproveDuplicate>();
}
