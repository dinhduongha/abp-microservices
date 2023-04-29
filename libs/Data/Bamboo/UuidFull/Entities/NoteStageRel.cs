using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("NoteId", "StageId")]
[Table("note_stage_rel")]
[Index("StageId", "NoteId", Name = "note_stage_rel_stage_id_note_id_idx")]
public partial class NoteStageRel
{
    [Key]
    [Column("note_id")]
    public Guid NoteId { get; set; }

    [Key]
    [Column("stage_id")]
    public long StageId { get; set; }

    [ForeignKey("NoteId")]
    [InverseProperty("NoteStageRels")]
    public virtual NoteNote Note { get; set; } = null!;
}
