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

[Table("barcode_nomenclature")]
public partial class BarcodeNomenclature
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("upc_ean_conv")]
    public string? UpcEanConv { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("gs1_separator_fnc1")]
    public string? Gs1SeparatorFnc1 { get; set; }

    [Column("is_gs1_nomenclature")]
    public bool? IsGs1Nomenclature { get; set; }

    [InverseProperty("BarcodeNomenclature")]
    [NotMapped]
    public virtual ICollection<BarcodeRule> BarcodeRules { get; } = new List<BarcodeRule>();

    [ForeignKey("CreatorId")]
    [InverseProperty("BarcodeNomenclatureCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Nomenclature")]
    [NotMapped]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("BarcodeNomenclatureWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
