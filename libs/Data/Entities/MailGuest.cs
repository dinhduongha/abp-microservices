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

[Table("mail_guest")]
public partial class MailGuest
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("timezone")]
    public string? Timezone { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("Guest")]
    public virtual BusPresence? BusPresence { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("MailGuests")]
    public virtual ResCountry? Country { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MailGuestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Guest")]
    public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    [InverseProperty("Guest")]
    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; } = new List<MailMessageReaction>();

    [InverseProperty("AuthorGuest")]
    public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("MailGuestWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
