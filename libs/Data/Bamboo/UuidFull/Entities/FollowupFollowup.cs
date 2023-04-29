using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("followup_followup")]
[Index("CompanyId", Name = "followup_followup_company_uniq", IsUnique = true)]
public partial class FollowupFollowup
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("FollowupFollowup")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("FollowupFollowupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Followup")]
    public virtual ICollection<FollowupLine> FollowupLines { get; } = new List<FollowupLine>();

    [InverseProperty("Followup")]
    public virtual ICollection<FollowupPrint> FollowupPrints { get; } = new List<FollowupPrint>();

    [ForeignKey("WriteUid")]
    [InverseProperty("FollowupFollowupWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
