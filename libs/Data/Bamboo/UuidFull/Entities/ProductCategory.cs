using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_category")]
[Index("ParentId", Name = "product_category_parent_id_index")]
[Index("ParentPath", Name = "product_category_parent_path_index")]
public partial class ProductCategory
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("complete_name")]
    public string? CompleteName { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("removal_strategy_id")]
    public Guid? RemovalStrategyId { get; set; }

    [Column("packaging_reserve_method")]
    public string? PackagingReserveMethod { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("RemovalStrategyId")]
    [InverseProperty("ProductCategories")]
    public virtual ProductRemoval? RemovalStrategy { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
