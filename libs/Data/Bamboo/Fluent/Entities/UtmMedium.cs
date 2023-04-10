using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class UtmMedium
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; } = new List<HrRecruitmentSource>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
