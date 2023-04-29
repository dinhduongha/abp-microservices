using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_demo_failure")]
public partial class IrDemoFailure
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("module_id")]
    public Guid? ModuleId { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("error")]
    public string? Error { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrDemoFailureCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("IrDemoFailures")]
    public virtual IrModuleModule? Module { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("IrDemoFailures")]
    public virtual IrDemoFailureWizard? Wizard { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrDemoFailureWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
