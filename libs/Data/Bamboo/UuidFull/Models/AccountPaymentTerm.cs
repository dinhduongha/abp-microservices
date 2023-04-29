using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountPaymentTerm
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public bool? DisplayOnInvoice { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLines { get; } = new List<AccountPaymentTermLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
