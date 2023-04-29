using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("CrmIapLeadMiningRequestId", "CrmTagId")]
[Table("crm_iap_lead_mining_request_crm_tag_rel")]
[Index("CrmTagId", "CrmIapLeadMiningRequestId", Name = "crm_iap_lead_mining_request_c_crm_tag_id_crm_iap_lead_minin_idx")]
public partial class CrmIapLeadMiningRequestCrmTagRel
{
    [Key]
    [Column("crm_iap_lead_mining_request_id")]
    public Guid CrmIapLeadMiningRequestId { get; set; }

    [Key]
    [Column("crm_tag_id")]
    public long CrmTagId { get; set; }

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequestCrmTagRels")]
    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
