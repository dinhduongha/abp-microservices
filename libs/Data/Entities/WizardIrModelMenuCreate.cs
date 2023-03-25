using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("wizard_ir_model_menu_create")]
public partial class WizardIrModelMenuCreate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("menu_id")]
    public Guid? MenuId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("WizardIrModelMenuCreateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("WizardIrModelMenuCreates")]
    public virtual IrUiMenu? Menu { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("WizardIrModelMenuCreateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
