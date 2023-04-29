using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("privacy_lookup_wizard")]
public partial class PrivacyLookupWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("log_id")]
    public Guid? LogId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("execution_details")]
    public string? ExecutionDetails { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PrivacyLookupWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LogId")]
    [InverseProperty("PrivacyLookupWizards")]
    public virtual PrivacyLog? Log { get; set; }

    [InverseProperty("Wizard")]
    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLines { get; } = new List<PrivacyLookupWizardLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("PrivacyLookupWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
