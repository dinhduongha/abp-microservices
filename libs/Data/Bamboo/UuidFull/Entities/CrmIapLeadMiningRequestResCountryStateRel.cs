using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("CrmIapLeadMiningRequestId", "ResCountryStateId")]
[Table("crm_iap_lead_mining_request_res_country_state_rel")]
[Index("ResCountryStateId", "CrmIapLeadMiningRequestId", Name = "crm_iap_lead_mining_request_r_res_country_state_id_crm_iap__idx")]
public partial class CrmIapLeadMiningRequestResCountryStateRel
{
    [Key]
    [Column("crm_iap_lead_mining_request_id")]
    public Guid CrmIapLeadMiningRequestId { get; set; }

    [Key]
    [Column("res_country_state_id")]
    public long ResCountryStateId { get; set; }

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequestResCountryStateRels")]
    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
