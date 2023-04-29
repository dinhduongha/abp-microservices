using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_removal")]
public partial class ProductRemoval
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("method")]
    public string? Method { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductRemovalCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RemovalStrategy")]
    public virtual ICollection<ProductCategory> ProductCategories { get; } = new List<ProductCategory>();

    [InverseProperty("RemovalStrategy")]
    public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductRemovalWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
