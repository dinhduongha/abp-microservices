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

[Table("website_route")]
public partial class WebsiteRoute
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("path")]
    public string? Path { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("WebsiteRouteCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Route")]
    public virtual ICollection<WebsiteRewrite> WebsiteRewrites { get; } = new List<WebsiteRewrite>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("WebsiteRouteWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
