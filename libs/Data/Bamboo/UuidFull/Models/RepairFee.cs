using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class RepairFee
{
    public Guid Id { get; set; }

    public Guid? RepairId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUom { get; set; }

    public Guid? InvoiceLineId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public decimal? ProductUomQty { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public bool? Invoiced { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMoveLine? InvoiceLine { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual RepairOrder? Repair { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
