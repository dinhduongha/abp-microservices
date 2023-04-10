using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountPaymentTerm
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public bool? DisplayOnInvoice { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLines { get; } = new List<AccountPaymentTermLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
