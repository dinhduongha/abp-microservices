using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("change_password_user")]
public partial class ChangePasswordUser
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("user_login")]
    public string? UserLogin { get; set; }

    [Column("new_passwd")]
    public string? NewPasswd { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ChangePasswordUserCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ChangePasswordUserUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("ChangePasswordUsers")]
    public virtual ChangePasswordWizard? Wizard { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ChangePasswordUserWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
