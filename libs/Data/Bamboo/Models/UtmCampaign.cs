using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class UtmCampaign
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public long? StageId { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public bool? IsAutoCampaign { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? TenantId { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual UtmStage? Stage { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<UtmTag> Campaigns { get; } = new List<UtmTag>();
}
