using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrExpense
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? SheetId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? PaymentMode { get; set; }

    public string? State { get; set; }

    public string? Reference { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public string? AnalyticDistribution { get; set; }

    public string? Description { get; set; }

    public decimal? UnitAmount { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTaxCompany { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? UntaxedAmount { get; set; }

    public decimal? TotalAmountCompany { get; set; }

    public bool? IsRefused { get; set; }

    public bool? Sample { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SaleOrderId { get; set; }

    public virtual AccountAccount? Account { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    //public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizards { get; } = new List<HrExpenseSplitWizard>();

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual HrExpenseSheet? Sheet { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; } = new List<HrExpenseApproveDuplicate>();

    //public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; } = new List<HrExpenseRefuseWizard>();

    //public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
