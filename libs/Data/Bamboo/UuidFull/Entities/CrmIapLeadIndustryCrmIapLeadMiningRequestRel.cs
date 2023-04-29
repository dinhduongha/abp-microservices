using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("CrmIapLeadMiningRequestId", "CrmIapLeadIndustryId")]
[Table("crm_iap_lead_industry_crm_iap_lead_mining_request_rel")]
[Index("CrmIapLeadIndustryId", "CrmIapLeadMiningRequestId", Name = "crm_iap_lead_industry_crm_iap_crm_iap_lead_industry_id_crm__idx")]
public partial class CrmIapLeadIndustryCrmIapLeadMiningRequestRel
{
    [Key]
    [Column("crm_iap_lead_mining_request_id")]
    public Guid CrmIapLeadMiningRequestId { get; set; }

    [Key]
    [Column("crm_iap_lead_industry_id")]
    public long CrmIapLeadIndustryId { get; set; }

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadIndustryCrmIapLeadMiningRequestRels")]
    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
