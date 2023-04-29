using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_request_count")]
public partial class StockRequestCount
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("set_count")]
    public string? SetCount { get; set; }

    [Column("inventory_date")]
    public DateOnly? InventoryDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("accounting_date")]
    public DateOnly? AccountingDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockRequestCountCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("StockRequestCountUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockRequestCountWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockRequestCountId")]
    [InverseProperty("StockRequestCounts")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
