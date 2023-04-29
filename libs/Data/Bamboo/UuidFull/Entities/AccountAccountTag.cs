using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_account_tag")]
public partial class AccountAccountTag
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("applicability")]
    public string? Applicability { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("tax_negate")]
    public bool? TaxNegate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAccountTagCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAccountTagWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
