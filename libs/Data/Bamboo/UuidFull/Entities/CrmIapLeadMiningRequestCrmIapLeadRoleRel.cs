using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("CrmIapLeadMiningRequestId", "CrmIapLeadRoleId")]
[Table("crm_iap_lead_mining_request_crm_iap_lead_role_rel")]
[Index("CrmIapLeadRoleId", "CrmIapLeadMiningRequestId", Name = "crm_iap_lead_mining_request_c_crm_iap_lead_role_id_crm_iap__idx")]
public partial class CrmIapLeadMiningRequestCrmIapLeadRoleRel
{
    [Key]
    [Column("crm_iap_lead_mining_request_id")]
    public Guid CrmIapLeadMiningRequestId { get; set; }

    [Key]
    [Column("crm_iap_lead_role_id")]
    public long CrmIapLeadRoleId { get; set; }

    [ForeignKey("CrmIapLeadMiningRequestId")]
    [InverseProperty("CrmIapLeadMiningRequestCrmIapLeadRoleRels")]
    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
