using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosCategory
{
    public long Id { get; set; }

    public long? ParentId { get; set; }

    public long? Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PosCategory> InverseParent { get; } = new List<PosCategory>();

    public virtual PosCategory? Parent { get; set; }

    //public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();
}
