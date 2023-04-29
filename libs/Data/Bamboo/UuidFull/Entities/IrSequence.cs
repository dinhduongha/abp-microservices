﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_sequence")]
public partial class IrSequence
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("number_next")]
    public long? NumberNext { get; set; }

    [Column("number_increment")]
    public long? NumberIncrement { get; set; }

    [Column("padding")]
    public long? Padding { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("implementation")]
    public string? Implementation { get; set; }

    [Column("prefix")]
    public string? Prefix { get; set; }

    [Column("suffix")]
    public string? Suffix { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("use_date_range")]
    public bool? UseDateRange { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("SecureSequence")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [ForeignKey("CompanyId")]
    [InverseProperty("IrSequences")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrSequenceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Sequence")]
    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRanges { get; } = new List<IrSequenceDateRange>();

    [InverseProperty("SequenceLine")]
    public virtual ICollection<PosConfig> PosConfigSequenceLines { get; } = new List<PosConfig>();

    [InverseProperty("Sequence")]
    public virtual ICollection<PosConfig> PosConfigSequences { get; } = new List<PosConfig>();

    [InverseProperty("SequenceNavigation")]
    public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrSequenceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
