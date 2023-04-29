using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("MailActivityTypeId", "MailTemplateId")]
[Table("mail_activity_type_mail_template_rel")]
[Index("MailTemplateId", "MailActivityTypeId", Name = "mail_activity_type_mail_templ_mail_template_id_mail_activit_idx")]
public partial class MailActivityTypeMailTemplateRel
{
    [Key]
    [Column("mail_activity_type_id")]
    public long MailActivityTypeId { get; set; }

    [Key]
    [Column("mail_template_id")]
    public Guid MailTemplateId { get; set; }

    [ForeignKey("MailTemplateId")]
    [InverseProperty("MailActivityTypeMailTemplateRels")]
    public virtual MailTemplate MailTemplate { get; set; } = null!;
}
