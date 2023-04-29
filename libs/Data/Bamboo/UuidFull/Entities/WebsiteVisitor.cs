using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("website_visitor")]
[Index("AccessToken", Name = "website_visitor_access_token_unique", IsUnique = true)]
public partial class WebsiteVisitor
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("lang_id")]
    public long? LangId { get; set; }

    [Column("visit_count")]
    public long? VisitCount { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("timezone")]
    public string? Timezone { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("last_connection_datetime", TypeName = "timestamp without time zone")]
    public DateTime? LastConnectionDatetime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebsiteVisitorCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("WebsiteVisitors")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("WebsiteVisitors")]
    public virtual Website? Website { get; set; }

    [InverseProperty("Visitor")]
    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    [ForeignKey("WriteUid")]
    [InverseProperty("WebsiteVisitorWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WebsiteVisitorId")]
    [InverseProperty("WebsiteVisitors")]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();
}
