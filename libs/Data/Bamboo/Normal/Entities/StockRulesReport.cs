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

[Table("stock_rules_report")]
public partial class StockRulesReport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("product_has_variants")]
    public bool? ProductHasVariants { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("StockRulesReportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    //[InverseProperty("StockRulesReports")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductTmplId")]
    //[InverseProperty("StockRulesReports")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("StockRulesReportWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockRulesReportId")]
    [InverseProperty("StockRulesReports")]
    [NotMapped]
    public virtual ICollection<StockRoute> StockRoutes { get; } = new List<StockRoute>();

    [ForeignKey("StockRulesReportId")]
    [InverseProperty("StockRulesReports")]
    [NotMapped]
    public virtual ICollection<StockWarehouse> StockWarehouses { get; } = new List<StockWarehouse>();
}
