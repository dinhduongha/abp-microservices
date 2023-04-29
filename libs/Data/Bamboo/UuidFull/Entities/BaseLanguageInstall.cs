using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_language_install")]
public partial class BaseLanguageInstall
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("overwrite")]
    public bool? Overwrite { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseLanguageInstallCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("LanguageWizard")]
    public virtual ICollection<ResLangInstallRel> ResLangInstallRels { get; } = new List<ResLangInstallRel>();

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseLanguageInstallWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("BaseLanguageInstallId")]
    [InverseProperty("BaseLanguageInstalls")]
    public virtual ICollection<Website> Websites { get; } = new List<Website>();
}
