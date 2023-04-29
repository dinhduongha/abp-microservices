using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_inventory_conflict")]
public partial class StockInventoryConflict
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockInventoryConflictCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockInventoryConflictWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockInventoryConflictId")]
    [InverseProperty("StockInventoryConflicts")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [ForeignKey("StockInventoryConflictId")]
    [InverseProperty("StockInventoryConflictsNavigation")]
    public virtual ICollection<StockQuant> StockQuantsNavigation { get; } = new List<StockQuant>();
}
