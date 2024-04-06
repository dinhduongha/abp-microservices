﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_share_wizard")]
public partial class ProjectShareWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("access_mode")]
    public string? AccessMode { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("display_access_mode")]
    public bool? DisplayAccessMode { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectShareWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectShareWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProjectShareWizardId")]
    [InverseProperty("ProjectShareWizards")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}