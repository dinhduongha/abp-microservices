﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[PrimaryKey("OsvMemoryId", "PartnerId")]
[Table("partner_stat_rel")]
[Index("PartnerId", "OsvMemoryId", Name = "partner_stat_rel_partner_id_osv_memory_id_idx")]
public partial class PartnerStatRel
{
    [Key]
    [Column("osv_memory_id")]
    public Guid OsvMemoryId { get; set; }

    [Key]
    [Column("partner_id")]
    public Guid PartnerId { get; set; }

    [ForeignKey("OsvMemoryId")]
    [InverseProperty("PartnerStatRels")]
    public virtual FollowupPrint OsvMemory { get; set; } = null!;
}
