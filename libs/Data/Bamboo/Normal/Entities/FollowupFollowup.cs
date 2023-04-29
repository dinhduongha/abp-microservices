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

[Table("followup_followup")]
[Index("TenantId", Name = "followup_followup_company_uniq", IsUnique = true)]
public partial class FollowupFollowup: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("FollowupFollowup")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("FollowupFollowupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("FollowupFollowupWriteUs")]
    public virtual ResUser? WriteU { get; set; }
    
    [InverseProperty("Followup")]
    [NotMapped]
    public virtual ICollection<FollowupLine> FollowupLines { get; } = new List<FollowupLine>();

    [InverseProperty("Followup")]
    [NotMapped]
    public virtual ICollection<FollowupPrint> FollowupPrints { get; } = new List<FollowupPrint>();

}
