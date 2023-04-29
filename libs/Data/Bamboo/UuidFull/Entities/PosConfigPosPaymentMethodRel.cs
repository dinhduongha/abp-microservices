using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("PosConfigId", "PosPaymentMethodId")]
[Table("pos_config_pos_payment_method_rel")]
[Index("PosPaymentMethodId", "PosConfigId", Name = "pos_config_pos_payment_method_pos_payment_method_id_pos_con_idx")]
public partial class PosConfigPosPaymentMethodRel
{
    [Key]
    [Column("pos_config_id")]
    public Guid PosConfigId { get; set; }

    [Key]
    [Column("pos_payment_method_id")]
    public long PosPaymentMethodId { get; set; }

    [ForeignKey("PosConfigId")]
    [InverseProperty("PosConfigPosPaymentMethodRels")]
    public virtual PosConfig PosConfig { get; set; } = null!;
}
