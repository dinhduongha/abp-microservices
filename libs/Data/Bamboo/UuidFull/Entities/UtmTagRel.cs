using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("TagId", "CampaignId")]
[Table("utm_tag_rel")]
[Index("CampaignId", "TagId", Name = "utm_tag_rel_campaign_id_tag_id_idx")]
public partial class UtmTagRel
{
    [Key]
    [Column("tag_id")]
    public Guid TagId { get; set; }

    [Key]
    [Column("campaign_id")]
    public long CampaignId { get; set; }

    [ForeignKey("TagId")]
    [InverseProperty("UtmTagRels")]
    public virtual UtmCampaign Tag { get; set; } = null!;
}
