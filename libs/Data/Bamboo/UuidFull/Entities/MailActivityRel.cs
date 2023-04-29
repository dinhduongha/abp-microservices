using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ActivityId", "RecommendedId")]
[Table("mail_activity_rel")]
[Index("RecommendedId", "ActivityId", Name = "mail_activity_rel_recommended_id_activity_id_idx")]
public partial class MailActivityRel
{
    [Key]
    [Column("activity_id")]
    public long ActivityId { get; set; }

    [Key]
    [Column("recommended_id")]
    public long RecommendedId { get; set; }
}
