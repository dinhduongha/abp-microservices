using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_import_tests_models_float")]
public partial class BaseImportTestsModelsFloat
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("value2")]
    public decimal? Value2 { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("value")]
    public double? Value { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseImportTestsModelsFloatCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseImportTestsModelsFloatWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
