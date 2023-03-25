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

[Table("stock_package_level")]
[Index("TenantId", Name = "stock_package_level_company_id_index")]
public partial class StockPackageLevel: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
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
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("StockPackageLevels")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
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
    [NotMapped]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("PackageLevel")]
    [NotMapped]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("StockPackageLevelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}