using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("theme_ir_asset")]
public partial class ThemeIrAsset
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("key")]
    public string? Key { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("bundle")]
    public string? Bundle { get; set; }

    [Column("directive")]
    public string? Directive { get; set; }

    [Column("path")]
    public string? Path { get; set; }

    [Column("target")]
    public string? Target { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ThemeIrAssetCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ThemeIrAssetWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
