using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductSupplierinfo
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public long Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public long? Delay { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCode { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public decimal? MinQty { get; set; }

    public decimal? Price { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfos { get; } = new List<StockReplenishmentInfo>();
}
