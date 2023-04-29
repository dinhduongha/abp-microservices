using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("crm_quotation_partner")]
public partial class CrmQuotationPartner
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("lead_id")]
    public Guid? LeadId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("action")]
    public string? Action { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("CrmQuotationPartnerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LeadId")]
    [InverseProperty("CrmQuotationPartners")]
    public virtual CrmLead? Lead { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("CrmQuotationPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("CrmQuotationPartnerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
