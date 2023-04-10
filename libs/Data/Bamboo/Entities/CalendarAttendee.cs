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

[Table("calendar_attendee")]
public partial class CalendarAttendee
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("event_id")]
    public Guid? EventId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("common_name")]
    public string? CommonName { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("availability")]
    public string? Availability { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CalendarAttendeeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EventId")]
    //[InverseProperty("CalendarAttendees")]
    public virtual CalendarEvent? Event { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("CalendarAttendees")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CalendarAttendeeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
