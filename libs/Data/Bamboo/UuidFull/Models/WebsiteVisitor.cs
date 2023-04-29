using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebsiteVisitor
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? PartnerId { get; set; }

    public long? CountryId { get; set; }

    public long? LangId { get; set; }

    public long? VisitCount { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AccessToken { get; set; }

    public string? Timezone { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastConnectionDatetime { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();
}
