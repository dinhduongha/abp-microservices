using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_storage_category_capacity")]
[Index("StorageCategoryId", Name = "stock_storage_category_capacity_storage_category_id_index")]
[Index("PackageTypeId", "StorageCategoryId", Name = "stock_storage_category_capacity_unique_package_type", IsUnique = true)]
[Index("ProductId", "StorageCategoryId", Name = "stock_storage_category_capacity_unique_product", IsUnique = true)]
public partial class StockStorageCategoryCapacity
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("storage_category_id")]
    public long? StorageCategoryId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("package_type_id")]
    public long? PackageTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("quantity")]
    public double? Quantity { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockStorageCategoryCapacityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockStorageCategoryCapacities")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockStorageCategoryCapacityWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
