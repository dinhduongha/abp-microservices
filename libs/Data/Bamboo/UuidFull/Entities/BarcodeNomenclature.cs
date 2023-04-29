using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("barcode_nomenclature")]
public partial class BarcodeNomenclature
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("upc_ean_conv")]
    public string? UpcEanConv { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("gs1_separator_fnc1")]
    public string? Gs1SeparatorFnc1 { get; set; }

    [Column("is_gs1_nomenclature")]
    public bool? IsGs1Nomenclature { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BarcodeNomenclatureCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BarcodeNomenclatureWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
