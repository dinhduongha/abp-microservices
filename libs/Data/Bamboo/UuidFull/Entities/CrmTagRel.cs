using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("LeadId", "TagId")]
[Table("crm_tag_rel")]
[Index("TagId", "LeadId", Name = "crm_tag_rel_tag_id_lead_id_idx")]
public partial class CrmTagRel
{
    [Key]
    [Column("lead_id")]
    public Guid LeadId { get; set; }

    [Key]
    [Column("tag_id")]
    public long TagId { get; set; }

    [ForeignKey("LeadId")]
    [InverseProperty("CrmTagRels")]
    public virtual CrmLead Lead { get; set; } = null!;
}
