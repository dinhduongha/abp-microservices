using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BasePartnerMergeAutomaticWizard
{
    public Guid Id { get; set; }

    public long? NumberGroup { get; set; }

    public Guid? CurrentLineId { get; set; }

    public Guid? DstPartnerId { get; set; }

    public long? MaximumGroup { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? State { get; set; }

    public bool? GroupByEmail { get; set; }

    public bool? GroupByName { get; set; }

    public bool? GroupByIsCompany { get; set; }

    public bool? GroupByVat { get; set; }

    public bool? GroupByParentId { get; set; }

    public bool? ExcludeContact { get; set; }

    public bool? ExcludeJournalItem { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLines { get; } = new List<BasePartnerMergeLine>();

    public virtual ResUser? CreateU { get; set; }

    public virtual BasePartnerMergeLine? CurrentLine { get; set; }

    public virtual ResPartner? DstPartner { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
