using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_work_location")]
public partial class HrWorkLocation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("address_id")]
    public Guid? AddressId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("location_number")]
    public string? LocationNumber { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("HrWorkLocations")]
    public virtual ResPartner? Address { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrWorkLocations")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrWorkLocationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("WorkLocation")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [ForeignKey("WriteUid")]
    [InverseProperty("HrWorkLocationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
