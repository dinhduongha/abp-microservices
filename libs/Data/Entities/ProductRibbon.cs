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

[Table("product_ribbon")]
public partial class ProductRibbon
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("bg_color")]
    public string? BgColor { get; set; }

    [Column("text_color")]
    public string? TextColor { get; set; }

    [Column("html_class")]
    public string? HtmlClass { get; set; }

    [Column("html", TypeName = "jsonb")]
    public string? Html { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ProductRibbonCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Ribbon")]
    public virtual ICollection<ProductTag> ProductTags { get; } = new List<ProductTag>();

    [InverseProperty("WebsiteRibbon")]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("ProductRibbonWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
