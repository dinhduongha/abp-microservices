using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_consumption_warning_line")]
public partial class MrpConsumptionWarningLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mrp_consumption_warning_id")]
    public Guid? MrpConsumptionWarningId { get; set; }

    [Column("mrp_production_id")]
    public Guid? MrpProductionId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("product_consumed_qty_uom")]
    public double? ProductConsumedQtyUom { get; set; }

    [Column("product_expected_qty_uom")]
    public double? ProductExpectedQtyUom { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpConsumptionWarningLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MrpConsumptionWarningId")]
    [InverseProperty("MrpConsumptionWarningLines")]
    public virtual MrpConsumptionWarning? MrpConsumptionWarning { get; set; }

    [ForeignKey("MrpProductionId")]
    [InverseProperty("MrpConsumptionWarningLines")]
    public virtual MrpProduction? MrpProduction { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MrpConsumptionWarningLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpConsumptionWarningLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
