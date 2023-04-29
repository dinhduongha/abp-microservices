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

[Table("website_track")]
[Index("PageId", Name = "website_track_page_id_index")]
[Index("Url", Name = "website_track_url_index")]
[Index("VisitorId", Name = "website_track_visitor_id_index")]
public partial class WebsiteTrack
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("visitor_id")]
    public Guid? VisitorId { get; set; }

    [Column("page_id")]
    public Guid? PageId { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("visit_datetime", TypeName = "timestamp without time zone")]
    public DateTime? VisitDatetime { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [ForeignKey("PageId")]
    [InverseProperty("WebsiteTracks")]
    public virtual WebsitePage? Page { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("WebsiteTracks")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("VisitorId")]
    [InverseProperty("WebsiteTracks")]
    public virtual WebsiteVisitor? Visitor { get; set; }
}
