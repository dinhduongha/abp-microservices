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

[Table("uom_category")]
public partial class UomCategory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("is_pos_groupable")]
    public bool? IsPosGroupable { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("UomCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Category")]
    [NotMapped]
    public virtual ICollection<UomUom> UomUoms { get; } = new List<UomUom>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("UomCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
