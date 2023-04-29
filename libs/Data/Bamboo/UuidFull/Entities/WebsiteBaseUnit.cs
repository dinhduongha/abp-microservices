using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("website_base_unit")]
public partial class WebsiteBaseUnit
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebsiteBaseUnitCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("BaseUnit")]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [InverseProperty("BaseUnit")]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    [ForeignKey("WriteUid")]
    [InverseProperty("WebsiteBaseUnitWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
