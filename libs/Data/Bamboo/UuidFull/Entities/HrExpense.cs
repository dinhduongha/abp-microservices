﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_expense")]
[Index("State", Name = "hr_expense_state_index")]
public partial class HrExpense
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("sheet_id")]
    public Guid? SheetId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("payment_mode")]
    public string? PaymentMode { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("reference")]
    public string? Reference { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("accounting_date")]
    public DateOnly? AccountingDate { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("unit_amount")]
    public decimal? UnitAmount { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("amount_tax")]
    public decimal? AmountTax { get; set; }

    [Column("amount_tax_company")]
    public decimal? AmountTaxCompany { get; set; }

    [Column("total_amount")]
    public decimal? TotalAmount { get; set; }

    [Column("untaxed_amount")]
    public decimal? UntaxedAmount { get; set; }

    [Column("total_amount_company")]
    public decimal? TotalAmountCompany { get; set; }

    [Column("is_refused")]
    public bool? IsRefused { get; set; }

    [Column("sample")]
    public bool? Sample { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_order_id")]
    public Guid? SaleOrderId { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("HrExpenses")]
    public virtual AccountAccount? Account { get; set; }

    [InverseProperty("Expense")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("CompanyId")]
    [InverseProperty("HrExpenses")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrExpenseCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrExpenses")]
    public virtual HrEmployee? Employee { get; set; }

    [InverseProperty("Expense")]
    public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizards { get; } = new List<HrExpenseSplitWizard>();

    [InverseProperty("Expense")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("HrExpenses")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HrExpenses")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("HrExpenses")]
    public virtual UomUom? ProductUom { get; set; }

    [ForeignKey("SaleOrderId")]
    [InverseProperty("HrExpenses")]
    public virtual SaleOrder? SaleOrder { get; set; }

    [ForeignKey("SheetId")]
    [InverseProperty("HrExpenses")]
    public virtual HrExpenseSheet? Sheet { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrExpenseWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrExpenseId")]
    [InverseProperty("HrExpenses")]
    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; } = new List<HrExpenseApproveDuplicate>();

    [ForeignKey("HrExpenseId")]
    [InverseProperty("HrExpenses")]
    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; } = new List<HrExpenseRefuseWizard>();

    [ForeignKey("ExpenseId")]
    [InverseProperty("Expenses")]
    public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
