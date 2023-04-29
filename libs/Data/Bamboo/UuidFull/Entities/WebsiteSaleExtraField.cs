using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("website_sale_extra_field")]
public partial class WebsiteSaleExtraField
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("field_id")]
    public Guid? FieldId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebsiteSaleExtraFieldCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FieldId")]
    [InverseProperty("WebsiteSaleExtraFields")]
    public virtual IrModelField? Field { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("WebsiteSaleExtraFields")]
    public virtual Website? Website { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("WebsiteSaleExtraFieldWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
