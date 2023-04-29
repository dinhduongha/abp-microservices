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

[Table("base_language_install")]
public partial class BaseLanguageInstall
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("overwrite")]
    public bool? Overwrite { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("BaseLanguageInstallCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("BaseLanguageInstallWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("LanguageWizardId")]
    [InverseProperty("LanguageWizards")]
    [NotMapped]
    public virtual ICollection<ResLang> Langs { get; } = new List<ResLang>();

    [ForeignKey("BaseLanguageInstallId")]
    [InverseProperty("BaseLanguageInstalls")]
    [NotMapped]
    public virtual ICollection<Website> Websites { get; } = new List<Website>();
}
