using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("followup_line")]
[Index("FollowupId", "Delay", Name = "followup_line_days_uniq", IsUnique = true)]
public partial class FollowupLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("followup_id")]
    public Guid? FollowupId { get; set; }

    [Column("delay")]
    public long? Delay { get; set; }

    [Column("manual_action_responsible_id")]
    public Guid? ManualActionResponsibleId { get; set; }

    [Column("email_template_id")]
    public Guid? EmailTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("manual_action_note")]
    public string? ManualActionNote { get; set; }

    [Column("send_email")]
    public bool? SendEmail { get; set; }

    [Column("send_letter")]
    public bool? SendLetter { get; set; }

    [Column("manual_action")]
    public bool? ManualAction { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("FollowupLine")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("CreateUid")]
    [InverseProperty("FollowupLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmailTemplateId")]
    [InverseProperty("FollowupLines")]
    public virtual MailTemplate? EmailTemplate { get; set; }

    [ForeignKey("FollowupId")]
    [InverseProperty("FollowupLines")]
    public virtual FollowupFollowup? Followup { get; set; }

    [ForeignKey("ManualActionResponsibleId")]
    [InverseProperty("FollowupLineManualActionResponsibles")]
    public virtual ResUser? ManualActionResponsible { get; set; }

    [InverseProperty("LatestFollowupLevelIdWithoutLitNavigation")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [ForeignKey("WriteUid")]
    [InverseProperty("FollowupLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
