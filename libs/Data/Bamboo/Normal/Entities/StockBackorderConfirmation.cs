﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("stock_backorder_confirmation")]
public partial class StockBackorderConfirmation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("show_transfers")]
    public bool? ShowTransfers { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("StockBackorderConfirmationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("StockBackorderConfirmationWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("BackorderConfirmation")]
    [NotMapped]
    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLines { get; } = new List<StockBackorderConfirmationLine>();

    [ForeignKey("StockBackorderConfirmationId")]
    [InverseProperty("StockBackorderConfirmations")]
    [NotMapped]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
