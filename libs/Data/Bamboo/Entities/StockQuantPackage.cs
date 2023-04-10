using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("stock_quant_package")]
[Index("TenantId", Name = "stock_quant_package_company_id_index")]
[Index("LocationId", Name = "stock_quant_package_location_id_index")]
[Index("PackageTypeId", Name = "stock_quant_package_package_type_id_index")]
public partial class StockQuantPackage: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("package_type_id")]
    public long? PackageTypeId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("package_use")]
    public string? PackageUse { get; set; }

    [Column("pack_date")]
    public DateOnly? PackDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("StockQuantPackages")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("StockQuantPackageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    //[InverseProperty("StockQuantPackages")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("PackageTypeId")]
    //[InverseProperty("StockQuantPackages")]
    public virtual StockPackageType? PackageType { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("StockQuantPackageWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Package")]
    [NotMapped]
    public virtual ICollection<StockMoveLine> StockMoveLinePackages { get; } = new List<StockMoveLine>();

    [InverseProperty("ResultPackage")]
    [NotMapped]
    public virtual ICollection<StockMoveLine> StockMoveLineResultPackages { get; } = new List<StockMoveLine>();

    [InverseProperty("Package")]
    [NotMapped]
    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    [InverseProperty("Package")]
    [NotMapped]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [InverseProperty("Package")]
    [NotMapped]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

}
