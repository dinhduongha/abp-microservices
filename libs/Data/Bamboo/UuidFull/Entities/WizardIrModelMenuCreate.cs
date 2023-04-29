using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("wizard_ir_model_menu_create")]
public partial class WizardIrModelMenuCreate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("menu_id")]
    public Guid? MenuId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WizardIrModelMenuCreateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("WizardIrModelMenuCreates")]
    public virtual IrUiMenu? Menu { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("WizardIrModelMenuCreateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
