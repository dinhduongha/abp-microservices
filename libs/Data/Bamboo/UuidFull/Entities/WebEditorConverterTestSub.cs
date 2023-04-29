using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("web_editor_converter_test_sub")]
public partial class WebEditorConverterTestSub
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

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebEditorConverterTestSubCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Many2oneNavigation")]
    public virtual ICollection<WebEditorConverterTest> WebEditorConverterTests { get; } = new List<WebEditorConverterTest>();

    [ForeignKey("WriteUid")]
    [InverseProperty("WebEditorConverterTestSubWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
