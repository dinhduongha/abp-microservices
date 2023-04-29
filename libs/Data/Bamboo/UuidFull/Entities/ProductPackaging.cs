using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_packaging")]
[Index("Barcode", Name = "product_packaging_barcode_uniq", IsUnique = true)]
[Index("CompanyId", Name = "product_packaging_company_id_index")]
public partial class ProductPackaging
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("barcode")]
    public string? Barcode { get; set; }

    [Column("qty")]
    public decimal? Qty { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sales")]
    public bool? Sales { get; set; }

    [Column("package_type_id")]
    public long? PackageTypeId { get; set; }

    [Column("purchase")]
    public bool? Purchase { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ProductPackagings")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductPackagingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductPackagings")]
    public virtual ProductProduct? Product { get; set; }

    [InverseProperty("ProductPackaging")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("ProductPackaging")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("ProductPackaging")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductPackagingWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("PackagingId")]
    [InverseProperty("Packagings")]
    public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();
}
