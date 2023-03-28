using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SaleAdvancePaymentInv
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? DepositAccountId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AdvancePaymentMethod { get; set; }

    public decimal? FixedAmount { get; set; }

    public bool? DeductDownPayments { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Amount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? DepositAccount { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();
}
