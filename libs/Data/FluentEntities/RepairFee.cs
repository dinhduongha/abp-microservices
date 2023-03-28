using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class RepairFee
{
    public Guid Id { get; set; }

    public Guid? RepairId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUom { get; set; }

    public Guid? InvoiceLineId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public decimal? ProductUomQty { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public bool? Invoiced { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMoveLine? InvoiceLine { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual RepairOrder? Repair { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
