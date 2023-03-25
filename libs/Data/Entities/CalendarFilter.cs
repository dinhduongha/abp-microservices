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

[Table("calendar_filters")]
[Index("PartnerId", Name = "calendar_filters_partner_id_index")]
[Index("UserId", Name = "calendar_filters_user_id_index")]
[Index("UserId", "PartnerId", Name = "calendar_filters_user_id_partner_id_unique", IsUnique = true)]
public partial class CalendarFilter
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("partner_checked")]
    public bool? PartnerChecked { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CalendarFilterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("CalendarFilters")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("UserId")]
    //[InverseProperty("CalendarFilterUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CalendarFilterWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
