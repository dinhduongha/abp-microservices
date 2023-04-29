using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lunch_location")]
public partial class LunchLocation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("address")]
    public string? Address { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("LunchLocations")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LunchLocationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("LunchLocation")]
    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    [InverseProperty("LastLunchLocation")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    [ForeignKey("WriteUid")]
    [InverseProperty("LunchLocationWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("LunchLocationId")]
    [InverseProperty("LunchLocations")]
    public virtual ICollection<LunchAlert> LunchAlerts { get; } = new List<LunchAlert>();

    [ForeignKey("LunchLocationId")]
    [InverseProperty("LunchLocations")]
    public virtual ICollection<LunchSupplier> LunchSuppliers { get; } = new List<LunchSupplier>();
}
