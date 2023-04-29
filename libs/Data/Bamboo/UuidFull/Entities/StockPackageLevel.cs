using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_package_level")]
[Index("CompanyId", Name = "stock_package_level_company_id_index")]
public partial class StockPackageLevel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("package_id")]
    public Guid? PackageId { get; set; }

    [Column("picking_id")]
    public Guid? PickingId { get; set; }

    [Column("location_dest_id")]
    public Guid? LocationDestId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockPackageLevels")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockPackageLevelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationDestId")]
    [InverseProperty("StockPackageLevels")]
    public virtual StockLocation? LocationDest { get; set; }

    [ForeignKey("PackageId")]
    [InverseProperty("StockPackageLevels")]
    public virtual StockQuantPackage? Package { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("StockPackageLevels")]
    public virtual StockPicking? Picking { get; set; }

    [InverseProperty("PackageLevel")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("PackageLevel")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockPackageLevelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
