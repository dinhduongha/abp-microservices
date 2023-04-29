using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_link_preview")]
[Index("CreateDate", Name = "mail_link_preview_create_date_index")]
[Index("MessageId", Name = "mail_link_preview_message_id_index")]
public partial class MailLinkPreview
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_id")]
    public Guid? MessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("source_url")]
    public string? SourceUrl { get; set; }

    [Column("og_type")]
    public string? OgType { get; set; }

    [Column("og_title")]
    public string? OgTitle { get; set; }

    [Column("og_image")]
    public string? OgImage { get; set; }

    [Column("og_mimetype")]
    public string? OgMimetype { get; set; }

    [Column("image_mimetype")]
    public string? ImageMimetype { get; set; }

    [Column("og_description")]
    public string? OgDescription { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailLinkPreviewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("MailLinkPreviews")]
    public virtual MailMessage? Message { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailLinkPreviewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
