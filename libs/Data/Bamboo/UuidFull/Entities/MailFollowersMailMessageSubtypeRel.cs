using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("MailFollowersId", "MailMessageSubtypeId")]
[Table("mail_followers_mail_message_subtype_rel")]
[Index("MailMessageSubtypeId", "MailFollowersId", Name = "mail_followers_mail_message_s_mail_message_subtype_id_mail__idx")]
public partial class MailFollowersMailMessageSubtypeRel
{
    [Key]
    [Column("mail_followers_id")]
    public Guid MailFollowersId { get; set; }

    [Key]
    [Column("mail_message_subtype_id")]
    public long MailMessageSubtypeId { get; set; }

    [ForeignKey("MailFollowersId")]
    [InverseProperty("MailFollowersMailMessageSubtypeRels")]
    public virtual MailFollower MailFollowers { get; set; } = null!;
}
