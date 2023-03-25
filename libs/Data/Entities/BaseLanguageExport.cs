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

[Table("base_language_export")]
public partial class BaseLanguageExport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("format")]
    public string? Format { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("data")]
    public byte[]? Data { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("BaseLanguageExportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("BaseLanguageExportWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WizId")]
    [InverseProperty("Wizs")]
    [NotMapped]
    public virtual ICollection<IrModuleModule> Modules { get; } = new List<IrModuleModule>();
}
