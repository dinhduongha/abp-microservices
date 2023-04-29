using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("barcode_rule")]
public partial class BarcodeRule
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("barcode_nomenclature_id")]
    public long? BarcodeNomenclatureId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("encoding")]
    public string? Encoding { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("pattern")]
    public string? Pattern { get; set; }

    [Column("alias")]
    public string? Alias { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("associated_uom_id")]
    public Guid? AssociatedUomId { get; set; }

    [Column("gs1_content_type")]
    public string? Gs1ContentType { get; set; }

    [Column("gs1_decimal_usage")]
    public bool? Gs1DecimalUsage { get; set; }

    [ForeignKey("AssociatedUomId")]
    [InverseProperty("BarcodeRules")]
    public virtual UomUom? AssociatedUom { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BarcodeRuleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BarcodeRuleWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
