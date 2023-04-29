using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("snailmail_letter_missing_required_fields")]
public partial class SnailmailLetterMissingRequiredField
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("letter_id")]
    public Guid? LetterId { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("street")]
    public string? Street { get; set; }

    [Column("street2")]
    public string? Street2 { get; set; }

    [Column("zip")]
    public string? Zip { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SnailmailLetterMissingRequiredFieldCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LetterId")]
    [InverseProperty("SnailmailLetterMissingRequiredFields")]
    public virtual SnailmailLetter? Letter { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("SnailmailLetterMissingRequiredFields")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SnailmailLetterMissingRequiredFieldWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
