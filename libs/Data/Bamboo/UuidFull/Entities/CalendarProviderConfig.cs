using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("calendar_provider_config")]
public partial class CalendarProviderConfig
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("external_calendar_provider")]
    public string? ExternalCalendarProvider { get; set; }

    [Column("cal_client_id")]
    public string? CalClientId { get; set; }

    [Column("cal_client_secret")]
    public string? CalClientSecret { get; set; }

    [Column("microsoft_outlook_client_identifier")]
    public string? MicrosoftOutlookClientIdentifier { get; set; }

    [Column("microsoft_outlook_client_secret")]
    public string? MicrosoftOutlookClientSecret { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CalendarProviderConfigCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CalendarProviderConfigWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
