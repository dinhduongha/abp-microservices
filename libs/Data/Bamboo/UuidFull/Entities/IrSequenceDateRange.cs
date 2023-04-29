using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_sequence_date_range")]
public partial class IrSequenceDateRange
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence_id")]
    public Guid? SequenceId { get; set; }

    [Column("number_next")]
    public long? NumberNext { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrSequenceDateRangeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SequenceId")]
    [InverseProperty("IrSequenceDateRanges")]
    public virtual IrSequence? Sequence { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrSequenceDateRangeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
