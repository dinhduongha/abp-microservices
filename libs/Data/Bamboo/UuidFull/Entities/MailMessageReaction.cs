using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_message_reaction")]
public partial class MailMessageReaction
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_id")]
    public Guid? MessageId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("guest_id")]
    public Guid? GuestId { get; set; }

    [Column("content")]
    public string? Content { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("MailMessageReactions")]
    public virtual MailGuest? Guest { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("MailMessageReactions")]
    public virtual MailMessage? Message { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("MailMessageReactions")]
    public virtual ResPartner? Partner { get; set; }
}
