using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PurchaseOrderLine
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ProductUom { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? PartnerId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? ProductPackagingId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? State { get; set; }

    public string? QtyReceivedMethod { get; set; }

    public string? DisplayType { get; set; }

    public string? AnalyticDistribution { get; set; }

    public string? Name { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public decimal? QtyInvoiced { get; set; }

    public decimal? QtyReceived { get; set; }

    public decimal? QtyReceivedManual { get; set; }

    public decimal? QtyToInvoice { get; set; }

    public DateTime? DatePlanned { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? ProductUomQty { get; set; }

    public double? PriceTax { get; set; }

    public double? ProductPackagingQty { get; set; }

    public Guid? OrderpointId { get; set; }

    public string? ProductDescriptionVariants { get; set; }

    public bool? PropagateCancel { get; set; }

    public Guid? SaleOrderId { get; set; }

    public Guid? SaleLineId { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual PurchaseOrder? Order { get; set; }

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductPackaging? ProductPackaging { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    //public virtual ICollection<StockMove> StockMoveCreatedPurchaseLines { get; } = new List<StockMove>();

    //public virtual ICollection<StockMove> StockMovePurchaseLines { get; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
