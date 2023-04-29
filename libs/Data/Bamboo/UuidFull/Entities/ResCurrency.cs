using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_currency")]
[Index("Name", Name = "res_currency_unique_name", IsUnique = true)]
public partial class ResCurrency
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("symbol")]
    public string? Symbol { get; set; }

    [Column("decimal_places")]
    public long? DecimalPlaces { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("full_name")]
    public string? FullName { get; set; }

    [Column("position")]
    public string? Position { get; set; }

    [Column("currency_unit_label")]
    public string? CurrencyUnitLabel { get; set; }

    [Column("currency_subunit_label")]
    public string? CurrencySubunitLabel { get; set; }

    [Column("rounding")]
    public decimal? Rounding { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResCurrencyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResCurrencyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
