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

[Table("lunch_topping")]
public partial class LunchTopping: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("supplier_id")]
    public Guid? SupplierId { get; set; }

    [Column("topping_category")]
    public Guid? ToppingCategory { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("price")]
    public decimal? Price { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("LunchToppings")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("LunchToppingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SupplierId")]
    //[InverseProperty("LunchToppings")]
    public virtual LunchSupplier? Supplier { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("LunchToppingWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ToppingId")]
    [InverseProperty("Toppings")]
    [NotMapped]
    public virtual ICollection<LunchOrder> Orders { get; } = new List<LunchOrder>();
}
