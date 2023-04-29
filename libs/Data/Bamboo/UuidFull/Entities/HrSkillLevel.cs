using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_skill_level")]
public partial class HrSkillLevel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("skill_type_id")]
    public long? SkillTypeId { get; set; }

    [Column("level_progress")]
    public Guid? LevelProgress { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("default_level")]
    public bool? DefaultLevel { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrSkillLevelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrSkillLevelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
