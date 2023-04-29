using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class UtmCampaign
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public long? StageId { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public bool? IsAutoCampaign { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? CompanyId { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? User { get; set; }

    public virtual ICollection<UtmTagRel> UtmTagRels { get; } = new List<UtmTagRel>();

    public virtual ResUser? WriteU { get; set; }
}
