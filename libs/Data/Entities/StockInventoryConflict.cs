using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("stock_inventory_conflict")]
public partial class StockInventoryConflict
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("StockInventoryConflictCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("StockInventoryConflictWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockInventoryConflictId")]
    [InverseProperty("StockInventoryConflicts")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [ForeignKey("StockInventoryConflictId")]
    [InverseProperty("StockInventoryConflictsNavigation")]
    public virtual ICollection<StockQuant> StockQuantsNavigation { get; } = new List<StockQuant>();
}
