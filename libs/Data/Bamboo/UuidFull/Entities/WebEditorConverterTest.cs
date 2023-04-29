using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("web_editor_converter_test")]
public partial class WebEditorConverterTest
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("integer")]
    public long? Integer { get; set; }

    [Column("many2one")]
    public Guid? Many2one { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("char")]
    public string? Char { get; set; }

    [Column("selection_str")]
    public string? SelectionStr { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("html")]
    public string? Html { get; set; }

    [Column("text")]
    public string? Text { get; set; }

    [Column("numeric")]
    public decimal? Numeric { get; set; }

    [Column("datetime", TypeName = "timestamp without time zone")]
    public DateTime? Datetime { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("float")]
    public double? Float { get; set; }

    [Column("binary")]
    public byte[]? Binary { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebEditorConverterTestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("Many2one")]
    [InverseProperty("WebEditorConverterTests")]
    public virtual WebEditorConverterTestSub? Many2oneNavigation { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("WebEditorConverterTestWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
