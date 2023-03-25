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

[Table("sale_advance_payment_inv")]
public partial class SaleAdvancePaymentInv: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("deposit_account_id")]
    public Guid? DepositAccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("advance_payment_method")]
    public string? AdvancePaymentMethod { get; set; }

    [Column("fixed_amount")]
    public decimal? FixedAmount { get; set; }

    [Column("deduct_down_payments")]
    public bool? DeductDownPayments { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("SaleAdvancePaymentInvs")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("SaleAdvancePaymentInvCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("SaleAdvancePaymentInvs")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("DepositAccountId")]
    [InverseProperty("SaleAdvancePaymentInvs")]
    public virtual AccountAccount? DepositAccount { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("SaleAdvancePaymentInvs")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("SaleAdvancePaymentInvWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SaleAdvancePaymentInvId")]
    [InverseProperty("SaleAdvancePaymentInvs")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    [ForeignKey("SaleAdvancePaymentInvId")]
    [InverseProperty("SaleAdvancePaymentInvs")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();
}
