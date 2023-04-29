using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_quant_package")]
[Index("CompanyId", Name = "stock_quant_package_company_id_index")]
[Index("LocationId", Name = "stock_quant_package_location_id_index")]
[Index("PackageTypeId", Name = "stock_quant_package_package_type_id_index")]
public partial class StockQuantPackage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("package_type_id")]
    public long? PackageTypeId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("package_use")]
    public string? PackageUse { get; set; }

    [Column("pack_date")]
    public DateOnly? PackDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockQuantPackages")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockQuantPackageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("StockQuantPackages")]
    public virtual StockLocation? Location { get; set; }

    [InverseProperty("Package")]
    public virtual ICollection<StockMoveLine> StockMoveLinePackages { get; } = new List<StockMoveLine>();

    [InverseProperty("ResultPackage")]
    public virtual ICollection<StockMoveLine> StockMoveLineResultPackages { get; } = new List<StockMoveLine>();

    [InverseProperty("Package")]
    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    [InverseProperty("Package")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [InverseProperty("Package")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockQuantPackageWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
