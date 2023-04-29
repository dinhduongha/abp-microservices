﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("stock_quant")]
[Index("LocationId", Name = "stock_quant_location_id_index")]
[Index("LotId", Name = "stock_quant_lot_id_index")]
[Index("PackageId", Name = "stock_quant_package_id_index")]
[Index("ProductId", Name = "stock_quant_product_id_index")]
public partial class StockQuant: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("storage_category_id")]
    public long? StorageCategoryId { get; set; }

    [Column("lot_id")]
    public Guid? LotId { get; set; }

    [Column("package_id")]
    public Guid? PackageId { get; set; }

    [Column("owner_id")]
    public Guid? OwnerId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("inventory_date")]
    public DateOnly? InventoryDate { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("reserved_quantity")]
    public decimal? ReservedQuantity { get; set; }

    [Column("inventory_quantity")]
    public decimal? InventoryQuantity { get; set; }

    [Column("inventory_diff_quantity")]
    public decimal? InventoryDiffQuantity { get; set; }

    [Column("inventory_quantity_set")]
    public bool? InventoryQuantitySet { get; set; }

    [Column("in_date", TypeName = "timestamp without time zone")]
    public DateTime? InDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("accounting_date")]
    public DateOnly? AccountingDate { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("StockQuants")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("StockQuantCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    //[InverseProperty("StockQuants")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("LotId")]
    //[InverseProperty("StockQuants")]
    public virtual StockLot? Lot { get; set; }

    [ForeignKey("OwnerId")]
    //[InverseProperty("StockQuants")]
    public virtual ResPartner? Owner { get; set; }

    [ForeignKey("PackageId")]
    //[InverseProperty("StockQuants")]
    public virtual StockQuantPackage? Package { get; set; }

    [ForeignKey("ProductId")]
    //[InverseProperty("StockQuants")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("StorageCategoryId")]
    //[InverseProperty("StockQuants")]
    public virtual StockStorageCategory? StorageCategory { get; set; }

    [ForeignKey("UserId")]
    //[InverseProperty("StockQuantUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("StockQuantWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockQuantId")]
    [InverseProperty("StockQuants")]
    [NotMapped]
    public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNames { get; } = new List<StockInventoryAdjustmentName>();

    [ForeignKey("StockQuantId")]
    [InverseProperty("StockQuants")]
    [NotMapped]
    public virtual ICollection<StockInventoryConflict> StockInventoryConflicts { get; } = new List<StockInventoryConflict>();

    [ForeignKey("StockQuantId")]
    [InverseProperty("StockQuantsNavigation")]
    [NotMapped]
    public virtual ICollection<StockInventoryConflict> StockInventoryConflictsNavigation { get; } = new List<StockInventoryConflict>();

    [ForeignKey("StockQuantId")]
    [InverseProperty("StockQuants")]
    [NotMapped]
    public virtual ICollection<StockInventoryWarning> StockInventoryWarnings { get; } = new List<StockInventoryWarning>();

    [ForeignKey("StockQuantId")]
    [InverseProperty("StockQuants")]
    [NotMapped]
    public virtual ICollection<StockRequestCount> StockRequestCounts { get; } = new List<StockRequestCount>();

    [ForeignKey("StockQuantId")]
    [InverseProperty("StockQuants")]
    [NotMapped]
    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmations { get; } = new List<StockTrackConfirmation>();
}
