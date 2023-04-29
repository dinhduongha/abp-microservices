using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SaleAdvancePaymentInv
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? DepositAccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AdvancePaymentMethod { get; set; }

    public decimal? FixedAmount { get; set; }

    public bool? DeductDownPayments { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Amount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountAccount? DepositAccount { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();
}
