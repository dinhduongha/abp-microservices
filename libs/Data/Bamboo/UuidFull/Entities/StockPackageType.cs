using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_package_type")]
[Index("Barcode", Name = "stock_package_type_barcode_uniq", IsUnique = true)]
[Index("CompanyId", Name = "stock_package_type_company_id_index")]
public partial class StockPackageType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("height")]
    public long? Height { get; set; }

    [Column("width")]
    public long? Width { get; set; }

    [Column("packaging_length")]
    public long? PackagingLength { get; set; }

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

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("base_weight")]
    public double? BaseWeight { get; set; }

    [Column("max_weight")]
    public double? MaxWeight { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockPackageTypes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockPackageTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockPackageTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
