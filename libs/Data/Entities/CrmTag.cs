using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("crm_tag")]
[Index("Name", Name = "crm_tag_name_uniq", IsUnique = true)]
public partial class CrmTag
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CrmTagCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CrmTagWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CrmTagId")]
    [InverseProperty("CrmTags")]
    [NotMapped]
    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; } = new List<CrmIapLeadMiningRequest>();

    [ForeignKey("TagId")]
    [InverseProperty("Tags")]
    [NotMapped]
    public virtual ICollection<CrmLead> Leads { get; } = new List<CrmLead>();

    [ForeignKey("TagId")]
    [InverseProperty("Tags")]
    [NotMapped]
    public virtual ICollection<SaleOrder> Orders { get; } = new List<SaleOrder>();
}
