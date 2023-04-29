using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lunch_cashmove")]
public partial class LunchCashmove
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LunchCashmoveCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("LunchCashmoveUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("LunchCashmoveWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
