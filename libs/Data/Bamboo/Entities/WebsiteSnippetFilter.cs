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

[Table("website_snippet_filter")]
[Index("IsPublished", Name = "website_snippet_filter_is_published_index")]
[Index("WebsiteId", Name = "website_snippet_filter_website_id_index")]
public partial class WebsiteSnippetFilter
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("action_server_id")]
    public Guid? ActionServerId { get; set; }

    [Column("filter_id")]
    public Guid? FilterId { get; set; }

    [Column("limit")]
    public Guid? Limit { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("field_names")]
    public string? FieldNames { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("is_published")]
    public bool? IsPublished { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("product_cross_selling")]
    public bool? ProductCrossSelling { get; set; }

    [ForeignKey("ActionServerId")]
    //[InverseProperty("WebsiteSnippetFilters")]
    public virtual IrActServer? ActionServer { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("WebsiteSnippetFilterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FilterId")]
    //[InverseProperty("WebsiteSnippetFilters")]
    public virtual IrFilter? Filter { get; set; }

    [ForeignKey("WebsiteId")]
    //[InverseProperty("WebsiteSnippetFilters")]
    public virtual Website? Website { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("WebsiteSnippetFilterWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
