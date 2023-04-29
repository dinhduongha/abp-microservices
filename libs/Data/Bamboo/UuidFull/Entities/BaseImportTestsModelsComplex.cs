using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_import_tests_models_complex")]
public partial class BaseImportTestsModelsComplex
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

    [Column("c")]
    public string? C { get; set; }

    [Column("d")]
    public DateOnly? D { get; set; }

    [Column("m")]
    public decimal? M { get; set; }

    [Column("dt", TypeName = "timestamp without time zone")]
    public DateTime? Dt { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("f")]
    public double? F { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseImportTestsModelsComplexCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseImportTestsModelsComplexWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
