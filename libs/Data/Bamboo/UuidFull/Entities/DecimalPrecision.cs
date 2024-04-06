﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("decimal_precision")]
[Index("Name", Name = "decimal_precision_name_uniq", IsUnique = true)]
public partial class DecimalPrecision
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("digits")]
    public long? Digits { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("DecimalPrecisionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("DecimalPrecisionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}