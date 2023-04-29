using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("change_password_wizard")]
public partial class ChangePasswordWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Wizard")]
    public virtual ICollection<ChangePasswordUser> ChangePasswordUsers { get; } = new List<ChangePasswordUser>();

    [ForeignKey("CreateUid")]
    [InverseProperty("ChangePasswordWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ChangePasswordWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
