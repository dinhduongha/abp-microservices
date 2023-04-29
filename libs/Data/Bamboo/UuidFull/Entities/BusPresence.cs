using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("bus_presence")]
public partial class BusPresence
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    [Column("last_poll", TypeName = "timestamp without time zone")]
    public DateTime? LastPoll { get; set; }

    [Column("last_presence", TypeName = "timestamp without time zone")]
    public DateTime? LastPresence { get; set; }

    [Column("guest_id")]
    public Guid? GuestId { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("BusPresence")]
    public virtual MailGuest? Guest { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("BusPresence")]
    public virtual ResUser? User { get; set; }
}
