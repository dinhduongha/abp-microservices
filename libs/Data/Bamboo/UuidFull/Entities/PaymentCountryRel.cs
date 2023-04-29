using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("PaymentId", "CountryId")]
[Table("payment_country_rel")]
[Index("CountryId", "PaymentId", Name = "payment_country_rel_country_id_payment_id_idx")]
public partial class PaymentCountryRel
{
    [Key]
    [Column("payment_id")]
    public Guid PaymentId { get; set; }

    [Key]
    [Column("country_id")]
    public long CountryId { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("PaymentCountryRels")]
    public virtual PaymentProvider Payment { get; set; } = null!;
}
