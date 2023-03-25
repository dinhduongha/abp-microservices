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

[Table("product_supplierinfo")]
[Index("TenantId", Name = "product_supplierinfo_company_id_index")]
[Index("ProductTmplId", Name = "product_supplierinfo_product_tmpl_id_index")]
public partial class ProductSupplierinfo: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("delay")]
    public long? Delay { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("product_name")]
    public string? ProductName { get; set; }

    [Column("product_code")]
    public string? ProductCode { get; set; }

    [Column("date_start")]
    public DateOnly? DateStart { get; set; }

    [Column("date_end")]
    public DateOnly? DateEnd { get; set; }

    [Column("min_qty")]
    public decimal? MinQty { get; set; }

    [Column("price")]
    public decimal? Price { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("ProductSupplierinfos")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ProductSupplierinfoCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("ProductSupplierinfos")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ProductSupplierinfos")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductSupplierinfos")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductSupplierinfos")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [InverseProperty("Supplier")]
    [NotMapped]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("ProductSupplierinfoWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductSupplierinfoId")]
    [InverseProperty("ProductSupplierinfos")]
    [NotMapped]
    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfos { get; } = new List<StockReplenishmentInfo>();
}
