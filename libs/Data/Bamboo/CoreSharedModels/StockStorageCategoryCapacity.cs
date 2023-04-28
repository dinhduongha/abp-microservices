using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Models;

[Table("stock_storage_category_capacity")]
//[Index("StorageCategoryId", Name = "stock_storage_category_capacity_storage_category_id_index")]
//[Index("PackageTypeId", "StorageCategoryId", Name = "stock_storage_category_capacity_unique_package_type", IsUnique = true)]
//[Index("ProductId", "StorageCategoryId", Name = "stock_storage_category_capacity_unique_product", IsUnique = true)]
public partial class StockStorageCategoryCapacity: Entity<Guid>, IEntityDto<Guid>
{
    [Key]
    [Column("id")]
    public Guid Id { get => base.Id; set => base.Id = value; }

    [Column("storage_category_id")]
    public long? StorageCategoryId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("package_type_id")]
    public long? PackageTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("quantity")]
    public double? Quantity { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("StockStorageCategoryCapacityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PackageTypeId")]
    //[InverseProperty("StockStorageCategoryCapacities")]
    public virtual StockPackageType? PackageType { get; set; }

    [ForeignKey("ProductId")]
    //[InverseProperty("StockStorageCategoryCapacities")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("StorageCategoryId")]
    //[InverseProperty("StockStorageCategoryCapacities")]
    public virtual StockStorageCategory? StorageCategory { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("StockStorageCategoryCapacityWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
