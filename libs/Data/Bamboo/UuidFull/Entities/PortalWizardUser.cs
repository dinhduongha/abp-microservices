using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("portal_wizard_user")]
public partial class PortalWizardUser
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PortalWizardUserCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PortalWizardUsers")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("PortalWizardUsers")]
    public virtual PortalWizard? Wizard { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PortalWizardUserWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
