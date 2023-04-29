using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("web_tour_tour")]
public partial class WebTourTour
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("WebTourTours")]
    public virtual ResUser? User { get; set; }
}
