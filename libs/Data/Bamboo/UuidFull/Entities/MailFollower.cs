using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_followers")]
[Index("ResModel", "ResId", "PartnerId", Name = "mail_followers_mail_followers_res_partner_res_model_id_uniq", IsUnique = true)]
[Index("PartnerId", Name = "mail_followers_partner_id_index")]
[Index("ResId", Name = "mail_followers_res_id_index")]
[Index("ResModel", Name = "mail_followers_res_model_index")]
public partial class MailFollower
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [InverseProperty("MailFollowers")]
    public virtual ICollection<MailFollowersMailMessageSubtypeRel> MailFollowersMailMessageSubtypeRels { get; } = new List<MailFollowersMailMessageSubtypeRel>();

    [ForeignKey("PartnerId")]
    [InverseProperty("MailFollowers")]
    public virtual ResPartner? Partner { get; set; }
}
