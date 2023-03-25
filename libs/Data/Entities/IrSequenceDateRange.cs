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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("IrSequenceDateRangeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SequenceId")]
    //[InverseProperty("IrSequenceDateRanges")]
    public virtual IrSequence? Sequence { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("IrSequenceDateRangeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
