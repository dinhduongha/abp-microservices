﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_partner_industry")]
public partial class ResPartnerIndustry
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("full_name", TypeName = "jsonb")]
    public string? FullName { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResPartnerIndustryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResPartnerIndustryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
