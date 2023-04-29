using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("CrmIapLeadMiningRequestId", "ResCountryId")]
[Table("crm_iap_lead_mining_request_res_country_rel")]
[Index("ResCountryId", "CrmIapLeadMiningRequestId", Name = "crm_iap_lead_mining_request_r_res_country_id_crm_iap_lead_m_idx")]
public partial class CrmIapLeadMiningRequestResCountryRel
{
    [Key]
    [Column("crm_iap_lead_mining_request_id")]
    public Guid CrmIapLeadMiningRequestId { get; set; }

    [Key]
    [Column("res_country_id")]
    public long ResCountryId { get; set; }

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequestResCountryRels")]
    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
