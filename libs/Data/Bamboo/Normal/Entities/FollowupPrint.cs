﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("followup_print")]
public partial class FollowupPrint
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("followup_id")]
    public Guid? FollowupId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("email_subject")]
    public string? EmailSubject { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("email_body")]
    public string? EmailBody { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("email_conf")]
    public bool? EmailConf { get; set; }

    [Column("partner_lang")]
    public bool? PartnerLang { get; set; }

    [Column("test_print")]
    public bool? TestPrint { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("FollowupPrintCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FollowupId")]
    //[InverseProperty("FollowupPrints")]
    public virtual FollowupFollowup? Followup { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("FollowupPrintWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("OsvMemory")]
    [NotMapped]
    public virtual ICollection<PartnerStatRel> PartnerStatRels { get; } = new List<PartnerStatRel>();

}
