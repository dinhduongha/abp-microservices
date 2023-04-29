using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_team_member")]
[Index("CrmTeamId", Name = "crm_team_member_crm_team_id_index")]
[Index("UserId", Name = "crm_team_member_user_id_index")]
public partial class CrmTeamMember
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("crm_team_id")]
    public Guid? CrmTeamId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("assignment_max")]
    public Guid? AssignmentMax { get; set; }

    [Column("assignment_domain")]
    public string? AssignmentDomain { get; set; }

    [Column("assignment_optout")]
    public bool? AssignmentOptout { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmTeamMemberCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CrmTeamId")]
    [InverseProperty("CrmTeamMembers")]
    public virtual CrmTeam? CrmTeam { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("CrmTeamMembers")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CrmTeamMemberUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmTeamMemberWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
