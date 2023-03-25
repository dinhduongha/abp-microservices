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

[Table("web_editor_converter_test_sub")]
public partial class WebEditorConverterTestSub
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("WebEditorConverterTestSubCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Many2oneNavigation")]
    public virtual ICollection<WebEditorConverterTest> WebEditorConverterTests { get; } = new List<WebEditorConverterTest>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("WebEditorConverterTestSubWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
