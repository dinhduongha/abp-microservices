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

[Table("hr_work_location")]
public partial class HrWorkLocation: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("address_id")]
    public Guid? AddressId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("location_number")]
    public string? LocationNumber { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("HrWorkLocations")]
    public virtual ResPartner? Address { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("HrWorkLocations")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrWorkLocationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("WorkLocation")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrWorkLocationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
