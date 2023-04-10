using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockQuant
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? LocationId { get; set; }

    public long? StorageCategoryId { get; set; }

    public Guid? LotId { get; set; }

    public Guid? PackageId { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? InventoryDate { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ReservedQuantity { get; set; }

    public decimal? InventoryQuantity { get; set; }

    public decimal? InventoryDiffQuantity { get; set; }

    public bool? InventoryQuantitySet { get; set; }

    public DateTime? InDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLot? Lot { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockStorageCategory? StorageCategory { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNames { get; } = new List<StockInventoryAdjustmentName>();

    //public virtual ICollection<StockInventoryConflict> StockInventoryConflicts { get; } = new List<StockInventoryConflict>();

    //public virtual ICollection<StockInventoryConflict> StockInventoryConflictsNavigation { get; } = new List<StockInventoryConflict>();

    //public virtual ICollection<StockInventoryWarning> StockInventoryWarnings { get; } = new List<StockInventoryWarning>();

    //public virtual ICollection<StockRequestCount> StockRequestCounts { get; } = new List<StockRequestCount>();

    //public virtual ICollection<StockTrackConfirmation> StockTrackConfirmations { get; } = new List<StockTrackConfirmation>();
}
