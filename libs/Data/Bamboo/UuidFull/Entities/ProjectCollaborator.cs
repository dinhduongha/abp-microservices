using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_collaborator")]
[Index("ProjectId", "PartnerId", Name = "project_collaborator_unique_collaborator", IsUnique = true)]
public partial class ProjectCollaborator
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("project_id")]
    public Guid? ProjectId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectCollaboratorCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ProjectCollaborators")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("ProjectCollaborators")]
    public virtual ProjectProject? Project { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectCollaboratorWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
