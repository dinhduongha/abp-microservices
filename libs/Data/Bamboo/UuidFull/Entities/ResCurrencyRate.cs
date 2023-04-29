using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_currency_rate")]
[Index("Name", Name = "res_currency_rate_name_index")]
[Index("Name", "CurrencyId", "CompanyId", Name = "res_currency_rate_unique_name_per_day", IsUnique = true)]
public partial class ResCurrencyRate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public DateOnly? Name { get; set; }

    [Column("rate")]
    public decimal? Rate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ResCurrencyRates")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResCurrencyRateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResCurrencyRateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
