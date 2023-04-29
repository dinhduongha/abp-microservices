using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_wizard_invite")]
public partial class MailWizardInvite
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("message")]
    public string? Message { get; set; }

    [Column("send_mail")]
    public bool? SendMail { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailWizardInviteCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailWizardInviteWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MailWizardInviteId")]
    [InverseProperty("MailWizardInvites")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
